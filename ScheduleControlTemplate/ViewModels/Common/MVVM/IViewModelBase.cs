using System.Collections.ObjectModel;
using Telerik.Windows.Controls;

namespace ScheduleControlTemplate.ViewModels
{
    public interface IViewModelBase
    {
        public string Title { get; set; }
        public bool IsBusy { get; set; }
        public string BusyContent { get; set; }
        public ObservableCollection<ToolBarModel> ToolBarModels { get; }
        public bool ToolBarEnabled { get; }
        public IViewModelBase ParentViewModel { get; set; }
        public IViewModelBase ViewModel { get; set; }
        public void RaiseViewModelChange();
        public DelegateCommand GoBackCommand { get; }
        public void OnGoBack();
        public void WhenBack();
        public bool NavigationEnabled { get; }
    }
}
