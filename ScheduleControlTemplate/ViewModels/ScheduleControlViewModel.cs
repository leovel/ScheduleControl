using ScheduleControl.Data.Services;
using ScheduleControl.Models;
using ScheduleControlTemplate.ViewModels.Rules;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Windows.Controls;

namespace ScheduleControlTemplate.ViewModels
{
    public class ScheduleControlViewModel : CustomManagementViewModelBase<ScheduleControlViewModel>
    {
        readonly ScheduleControlDataService _dataService;
        private readonly IDisposable propertyChangedSubscription;
        public ScheduleControlViewModel(ScheduleControlDataService dataService)
        {
            Title = "PARAMETRIZAÇÃO E EXPORTAÇÃO";
            _dataService = dataService;

            TemporaryWeekDayRange.BaseShift = MainShift;
            FillAllHollidays();

            propertyChangedSubscription = WhenPropertyChanged.Subscribe(p =>
            {
                ExportCommand.InvalidateCanExecute();
            });

            OnRulesPropertyCanged();
        }

        protected override void DisposeManaged()
        {
            propertyChangedSubscription.Dispose();
        }

        static ScheduleControlViewModel()
        {
            Rules.Add(new DelegateRule<ScheduleControlViewModel>(
                nameof(Begin),
                "A Data Inicial deve ser anterior a Data Final",
                x => x.Begin < x.End
                ));

            Rules.Add(new DelegateRule<ScheduleControlViewModel>(
                 nameof(End),
                 "A Data Final deve ser posterior Data Inicial",
                 x => x.Begin < x.End
                 ));
            Rules.Add(new DelegateRule<ScheduleControlViewModel>(
                 nameof(End),
                 "A Data Final não pode superar a Data Actual",
                 x => x.End < DateTime.Today.AddDays(1)
                 ));

        }

        internal override ObservableCollection<ToolBarModel> CreateToolBarModels()
        {
            var result = base.CreateToolBarModels();
            result.Add(new ToolBarModel()
            {
                BandIndex = result.Count,
                ToolBarItemModels = new ObservableCollection<ToolBarItemModelBase>()
                {
                    new ToolBarButtonModel() { Command = ExportCommand, ImagePath = "/Resources/Images/ToolBar/analyze_64px.png", ToolTip = "Gerar Relatório"}
                },
            });

            return result;
        }

        private DateTime begin = DateTime.Today.AddDays(-30);

        public DateTime Begin
        {
            get => begin;
            set => SetProperty(() => begin == value.Date, () =>
            {
                begin = value.Date;
                OnPropertyChanged(nameof(End));
                OnPropertyChanged(nameof(Holidays));
            });
        }

        private DateTime end = DateTime.Today.AddDays(1).AddMilliseconds(-1);

        public DateTime End
        {
            get => end;
            set => SetProperty(() => end == value.Date.AddDays(1).AddMilliseconds(-1), () =>
            {
                end = value.Date.AddDays(1).AddMilliseconds(-1);
                OnPropertyChanged(nameof(Begin));
                OnPropertyChanged(nameof(Holidays));
            });
        }

        public DateTime SelectableDateStart { get; } = DateTime.Today.AddYears(-2);
        public DateTime SelectableDateEnd { get; } = DateTime.UtcNow;

        private bool bridges;

        public bool Bridges
        {
            get => bridges;
            set 
            {
                if (SetProperty(ref bridges, value))
                {
                    OnPropertyChanged(nameof(Holidays));
                    if(!value)
                    {
                        BridgeTemporaries = false;
                    }
                }
            }
        }

        private bool bridgeTemporaries;

        public bool BridgeTemporaries
        {
            get => bridgeTemporaries;
            set => SetProperty(ref bridgeTemporaries, value);
        }

        public Shift MainShift { get; } = new();
        
        public List<Holiday> Holidays => allHolidays
            .Where(h => h.Date >= Begin && h.Date <= End && (Bridges || h.Bridge == false))
            .ToList();
     
        public ObservableCollection<TemporaryWeekDayRange> Temporaries { get; } = new();

        #region Commands
        private DelegateCommand exportCommand;
        public DelegateCommand ExportCommand =>
            exportCommand ??= new DelegateCommand(async o => await OnExport(), o => !HasErrors);

        private async Task OnExport()
        {
            var users = (await _dataService.GetActiveUsersAsync())
                .OrderBy(u => u.Department)
                .ThenBy(u => u.FullName);
            var transactionLogsDict = (await _dataService.GetLogsBetwenAsync(Begin, End))
                .GroupBy(tl => (tl.UserId, tl.Date)).ToDictionary(g => g.Key);

            if (BridgeTemporaries)
                FillBridgeTemporaries();

            EmployeeDataSource employeeMetadata = new();

            foreach (var user in users)
            {
                EmployeeMetadata metadata = new()
                {
                    Id = user.Id,
                    FullName = user.FullName,
                    Department = user.Department
                };
                for (DateTime date = Begin; date < End; date = date.AddDays(1))
                {
                    var horary = Temporaries.FirstOrDefault(t => t.Contains(date))?.AlternativeShift ??
                        bridgeTemporaryList.FirstOrDefault(t => t.Contains(date))?.AlternativeShift ?? MainShift;

                    var dayDetails = horary.GetDayDetails(date.DayOfWeek);

                    if (dayDetails.Active)
                    {
                        var holiday = Holidays.FirstOrDefault(h => h.Date == date);
                        var isHoliday = holiday is not null;
                        if (transactionLogsDict.TryGetValue((user.Id, date), out var dateLog))
                        {
                            var orderedDayLogs = dateLog.OrderBy(dl => dl.Time);
                            var clockIn = isHoliday ? null : orderedDayLogs.FirstOrDefault()?.Time;
                            metadata.Details.Add(new()
                            {
                                Date = date,
                                OnDutyTime = dayDetails.OnDutyTime,
                                OffDutyTime = dayDetails.OffDutyTime,
                                EarlyError = new(0, dayDetails.EarlyError, 0),
                                LateError = new(0, dayDetails.LateError, 0),

                                ClockIn = clockIn,
                                ClockOut = clockIn.HasValue ?
                                orderedDayLogs.LastOrDefault(dl => dl.Time.Subtract(clockIn.Value).TotalHours > 1)?.Time : null,
                                
                                IsHoliday = isHoliday,
                                HolidayDescription = isHoliday ? $"Feriado: {holiday.Description}" : string.Empty
                            });
                        } 
                    }
                }

                employeeMetadata.Add(metadata);
            }

            ViewModel = new MetadataViewModel(employeeMetadata, this);
        }
        #endregion Commands

        #region Utils

        private readonly List<Holiday> allHolidays = new();
        private void FillAllHollidays()
        {
            allHolidays.Clear();
            for (int year = SelectableDateStart.Year; year <= SelectableDateEnd.Year; year++)
            {
                foreach (var holiday in Holiday.Holidays(year, true))
                {
                    allHolidays.Add(holiday);
                }
            }
            OnPropertyChanged(nameof(Holidays));
            FillBridgeTemporaries();
        }

        private readonly List<TemporaryWeekDayRange> bridgeTemporaryList = new();
        private void FillBridgeTemporaries()
        {
            bridgeTemporaryList.Clear();
            foreach (var temporary in Holiday.GetTemporariesFromBridges(Holidays, MainShift))
            {
                bridgeTemporaryList.Add(temporary);
            }
            OnPropertyChanged(nameof(Temporaries));
        }
        #endregion
    }
}
