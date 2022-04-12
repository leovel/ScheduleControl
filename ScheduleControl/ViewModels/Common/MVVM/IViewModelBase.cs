using System.Collections.ObjectModel;
using Telerik.Windows.Controls;

namespace ScheduleControl.ViewModels
{
    public interface IViewModelBase
    {
        string Title { get; set; }
        bool IsBusy { get; set; }
        string BusyContent { get; set; }
        ObservableCollection<ToolBarModel> ToolBarModels { get; }
        bool ToolBarEnabled { get; }
        IViewModelBase ParentViewModel { get; set; }
        IViewModelBase ViewModel { get; set; }
        void RaiseViewModelChange();
        DelegateCommand GoBackCommand { get; }
        void OnGoBack();
        void WhenBack();
        bool NavigationEnabled { get; }
    }
}
