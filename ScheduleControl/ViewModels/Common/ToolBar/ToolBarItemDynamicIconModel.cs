namespace ScheduleControl.ViewModels
{
    public class ToolBarItemDynamicIconModel : ToolBarItemModelBase
    {
        private string iconPath;

        public string IconPath
        {
            get
            {
                return iconPath;
            }
            set
            {
                if (iconPath != value)
                {
                    iconPath = value;
                    RaisePropertyChanged();
                }
            }
        }
    }
}
