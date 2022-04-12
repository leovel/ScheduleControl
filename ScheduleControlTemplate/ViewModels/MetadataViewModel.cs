using ScheduleControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleControlTemplate.ViewModels
{
    public class MetadataViewModel : CustomManagementViewModelBase<MetadataViewModel>
    {
        private static EmployeeDataSource _dataSourse;
        public MetadataViewModel() : base()
        {
            OnPropertyChanged(nameof(DataSourse));
        }

        public MetadataViewModel(EmployeeDataSource dataSourse, IViewModelBase parentViewModel) : base(parentViewModel)
        {
            _dataSourse = dataSourse;
            OnPropertyChanged(nameof(DataSourse));
        }
        public EmployeeDataSource DataSourse => _dataSourse;
    }


}
