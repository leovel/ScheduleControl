using ScheduleControlTemplate.ViewModels;
using System.Windows;

namespace ScheduleControlTemplate.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(MainWindowViewModel mainWindowViewModel)
        {
            InitializeComponent();

            DataContext = mainWindowViewModel;

            MainWindowViewModel.MainContentControl = this;
        }
    }
}
