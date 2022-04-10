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
            OnRulesPropertyCanged();
        }

        static ScheduleControlViewModel()
        {
            Rules.Add(new DelegateRule<ScheduleControlViewModel>(
                nameof(Begin),
                "A Data Inicial deve ser anterior a Data Final",
                x => x.Begin >= x.End
                ));
            Rules.Add(new DelegateRule<ScheduleControlViewModel>(
                 nameof(End),
                 "A Data Final deve ser posterior Data Inicial",
                 x => x.Begin >= x.End
                 ));
            Rules.Add(new DelegateRule<ScheduleControlViewModel>(
                 nameof(End),
                 "A Data Final deve ser posterior Data Inicial",
                 x => x.Begin >= x.End
                 ));

            Rules.Add(new DelegateRule<ScheduleControlViewModel>(
                 nameof(End),
                 "A Data Final não pode superar a Data Actual",
                 x => x.End >= DateTime.Today.AddDays(1)
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
            });
        }

        public DateTime SelectableDateStart { get; set; } = DateTime.Today.AddYears(-2);
        public DateTime SelectableDateEnd { get; set; } = DateTime.UtcNow;

        private bool bridges;

        public bool Bridges
        {
            get => bridges;
            set => SetProperty(ref bridges, value);
        }

        private bool bridgeTemporaries;

        public bool BridgeTemporaries
        {
            get => bridgeTemporaries;
            set => SetProperty(ref bridgeTemporaries, value);
        }

        public Shift MainShift { get; } = new();

        public ObservableCollection<Holiday> Holidays { get; } = new();

        public ObservableCollection<TemporaryWeekDayRange> Temporaries { get; } = new();
    }
}
