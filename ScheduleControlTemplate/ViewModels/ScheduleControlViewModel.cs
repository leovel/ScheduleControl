using ScheduleControlTemplate.Data.Services;
using System;
using System.Collections.Generic;
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
            Initialize();
        }

        private async void Initialize()
        {
            
        }
    }
}
