using ScheduleControlTemplate.Data.Services;
using ScheduleControlTemplate.Models;
using ScheduleControlTemplate.ViewModels.Rules;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleControlTemplate.ViewModels
{
    public class ScheduleControlViewModel : CustomManagementViewModelBase<ScheduleControlViewModel>
    {
        readonly ScheduleControlDataService _dataService;
        public ScheduleControlViewModel(ScheduleControlDataService dataService)
        {
            _dataService = dataService;

            TemporaryWeekDayRange.BaseShift = MainShift;
            FillAllHollidays();

            OnRulesPropertyCanged();
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
                 "A Data Final deve ser posterior Data Inicial",
                 x => x.Begin < x.End
                 ));

            Rules.Add(new DelegateRule<ScheduleControlViewModel>(
                 nameof(End),
                 "A Data Final não pode superar a Data Actual",
                 x => x.End < DateTime.Today.AddDays(1)
                 ));

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

        private DateTime end = DateTime.Today;

        public DateTime End
        {
            get => end;
            set => SetProperty(() => end == value.Date, () =>
            {
                end = value.Date;
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

        private void FillAllHollidays()
        {
            allHolidays.Clear();
            for (int year = SelectableDateStart.Year; year <= SelectableDateEnd.Year; year++ )
            {
                foreach (var holiday in Holiday.Holidays(year, true))
                {
                    allHolidays.Add(holiday);
                }
            }
            OnPropertyChanged(nameof(Holidays));
            FillBridgeTemporaries();
        }

        private readonly List<Holiday> allHolidays = new();
        public List<Holiday> Holidays => allHolidays
            .Where(h => h.Date >= Begin && h.Date <= End && (Bridges || h.Bridge == false))
            .ToList();

        private readonly List<TemporaryWeekDayRange> bridgeTemporaryList = new();
        public ObservableCollection<TemporaryWeekDayRange> Temporaries { get; } = new();

        private void FillBridgeTemporaries()
        {
            bridgeTemporaryList.Clear();
            foreach (var temporary in Holiday.GetTemporariesFromBridges(Holidays, MainShift))
            {
                bridgeTemporaryList.Add(temporary);
            }
            OnPropertyChanged(nameof(Temporaries));
        }
    }
}
