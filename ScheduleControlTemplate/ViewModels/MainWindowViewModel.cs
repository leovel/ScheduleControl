using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ScheduleControlTemplate.ViewModels
{
    public class MainWindowViewModel : CustomManagementViewModelBase<MainWindowViewModel>
    {
        public static ContentControl MainContentControl { get; set; }
        public MainWindowViewModel(ScheduleControlViewModel scheduleControlViewModel) : base()
        {

            Items.Add(new NavigationItemModel
            {
                IconPath = "/Resources/Images/Menu/calendar_64px.png",
                Title = "Efectividade",
                Content = scheduleControlViewModel
            });
        }

        public ObservableCollection<NavigationItemModel> Items { get; set; } = new ObservableCollection<NavigationItemModel>();
        private NavigationItemModel selectedItem;

        public NavigationItemModel SelectedItem
        {
            get => selectedItem ??= Items.FirstOrDefault();
            set
            {
                if(SetProperty(ref selectedItem, value))
                {
                    selectedItem.Content?.WhenBack();
                }
            }
        }
    }
}
