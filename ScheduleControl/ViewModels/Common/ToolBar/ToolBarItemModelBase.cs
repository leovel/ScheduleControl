using Telerik.Windows.Controls;

namespace ScheduleControl.ViewModels
{
    public class ToolBarItemModelBase : ViewModelBase
    {
        private string imagePath;

        public string ImagePath
        {
            get
            {
                return imagePath;
            }
            set
            {
                if (imagePath != value)
                {
                    imagePath = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string ToolTip { get; set; }
    }
}
