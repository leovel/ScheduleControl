using ScheduleControl.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ScheduleControl.ViewModels
{
    [DataObject]
    public class MetadataViewModel : CustomManagementViewModelBase<MetadataViewModel>
    {
        private static List<EmployeeMetadata> _dataSource;
        private static DateTime _beginDate;
        private static DateTime _endDate;
        public MetadataViewModel() : base()
        {
            OnPropertyChanged(nameof(DataSourse));
        }

        public MetadataViewModel(List<EmployeeMetadata> dataSource, DateTime beginDate,DateTime endDate,
            IViewModelBase parentViewModel) : base(parentViewModel)
        {
            _beginDate = beginDate;
            _endDate = endDate;
            _dataSource = dataSource;
            OnPropertyChanged(nameof(DataSourse));
        }

        public DateTime BeginDate => _beginDate;
        public DateTime EndDate => _endDate;
        public List<EmployeeMetadata> DataSourse => _dataSource;
    }


}
