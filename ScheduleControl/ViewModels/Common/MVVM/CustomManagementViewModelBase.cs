using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Telerik.Windows.Controls;

namespace ScheduleControl.ViewModels
{
    public class CustomManagementViewModelBase<T> : NotifyDataErrorInfo<T>, IViewModelBase where T : CustomManagementViewModelBase<T>
    {
        public CustomManagementViewModelBase() : base() { }
        public CustomManagementViewModelBase(IViewModelBase parentViewModel) : this()
        {
            ParentViewModel = parentViewModel;
        }

        public void InvokeOnUIThread(Action action)
        {
            if (Application.Current?.Dispatcher.CheckAccess() ?? false)
            {
                action();
            }
            else
            {
                Application.Current?.Dispatcher.Invoke(action);
            }
        }

        public void BeginInvokeOnUIThread(Action action)
        {
            if (Application.Current?.Dispatcher.CheckAccess() ?? false)
            {
                action();
            }
            else
            {
                Application.Current?.Dispatcher.BeginInvoke(action);
            }
        }

        public string Title { get; set; }

        private ObservableCollection<ToolBarModel> toolBarModels;

        public ObservableCollection<ToolBarModel> ToolBarModels
        {
            get
            {
                if (toolBarModels == null)
                {
                    toolBarModels = CreateToolBarModels();
                }

                return toolBarModels;
            }
        }

        internal virtual ObservableCollection<ToolBarModel> CreateToolBarModels()
        {
            return CanGoBack ? new ObservableCollection<ToolBarModel>()
            {
                new ToolBarModel()
                {
                    ToolBarItemModels = new ObservableCollection<ToolBarItemModelBase>()
                    {
                        new ToolBarButtonModel()
                        {
                            Command = GoBackCommand,
                            ImagePath = "/Resources/Images/ToolBar/left_64px.png",
                            ToolTip = "Voltar"
                        },
                    },
                }
            } : new ObservableCollection<ToolBarModel>();
        }

        public bool ToolBarEnabled => ToolBarModels.Any();

        private IViewModelBase _parentViewModel;
        public IViewModelBase ParentViewModel
        {
            get { return _parentViewModel; }
            set
            {
                if(SetProperty(ref _parentViewModel, value))
                {
                    OnPropertyChanged(nameof(CanGoBack));
                    OnPropertyChanged(nameof(NavigationEnabled));
                }
            }
        }

        private IViewModelBase _viewModel;
        public IViewModelBase ViewModel
        {
            get => _viewModel?.ViewModel ?? this;
            set
            {
                if (SetProperty(ref _viewModel, value))
                {
                    RaiseViewModelChange();
                }
            }
        }

        public void RaiseViewModelChange()
        {
            OnPropertyChanged(nameof(ViewModel));
            ParentViewModel?.RaiseViewModelChange();
        }

        public bool CanGoBack => ParentViewModel != null;

        public DelegateCommand goBackCommand;
        public DelegateCommand GoBackCommand
        {
            get => goBackCommand ?? (goBackCommand = new DelegateCommand(o => OnGoBack(), o => CanGoBack));
        }
        public bool NavigationEnabled => !CanGoBack;

        private bool isBusy;
        public bool IsBusy
        {
            get => isBusy;
            set => SetProperty(ref isBusy, value);
        }

        private string busyContent;
        public string BusyContent
        {
            get => busyContent ?? (busyContent = string.Empty);
            set => SetProperty(ref busyContent, value);
        }

        public void OnGoBack()
        {
            if(CanGoBack)
            {
                ParentViewModel.WhenBack();
                ParentViewModel.ViewModel = null;
                ParentViewModel = null;
            }
        }

        public virtual void WhenBack()
        {
        }
    }
}
