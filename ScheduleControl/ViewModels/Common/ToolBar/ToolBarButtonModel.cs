using System.Windows.Input;

namespace ScheduleControl.ViewModels
{
    public class ToolBarButtonModel : ToolBarItemDynamicIconModel
    {
        public ICommand Command { get; set; }
    }
}
