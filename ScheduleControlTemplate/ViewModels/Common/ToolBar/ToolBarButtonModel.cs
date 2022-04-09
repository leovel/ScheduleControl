using System.Windows.Input;

namespace ScheduleControlTemplate.ViewModels
{
    public class ToolBarButtonModel : ToolBarItemDynamicIconModel
    {
        public ICommand Command { get; set; }
    }
}
