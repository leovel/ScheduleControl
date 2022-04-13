using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ScheduleControl.Data.Infrastructure;
using ScheduleControl.Data.Services;
using ScheduleControl.ViewModels;
using ScheduleControl.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows;
using Telerik.Windows.Controls;

namespace ScheduleControl
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("pt");
            this.

            configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            StyleManager.ApplicationTheme = new FluentTheme();

            var services = new ServiceCollection();
            ConfigureServices(services);
            serviceProvider = services.BuildServiceProvider();

            InitializeComponent();
        }
        private readonly ServiceProvider serviceProvider;
        private readonly IConfigurationRoot configuration;

        private void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton(new TmsReplicaDatabaseSettings
            {
                ConnectionString = configuration.GetSection("TmsReplicaDatabase")["ConnectionString"],
                DatabaseName = configuration.GetSection("TmsReplicaDatabase")["DatabaseName"],
                TransactionLogsCollectionName = configuration.GetSection("TmsReplicaDatabase")["TransactionLogsCollectionName"],
                UsersCollectionName = configuration.GetSection("TmsReplicaDatabase")["UsersCollectionName"]
            });
            //services.AddTransient<IFuncionarioRepository, FuncionarioRepository>();
            services.AddSingleton<ScheduleControlDataService>();
            services.AddSingleton<ScheduleControlViewModel>();
            services.AddSingleton<MainWindowViewModel>();
            services.AddSingleton<MainWindow>();
        }

        private readonly DateTime END_DATE = new DateTime(2022, 5, 1);
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            if (DateTime.Now > END_DATE)
            {
                RadWindow.Alert(new DialogParameters
                {
                    Header = "Licence Expired",
                    Content = $"Please contact K&M - TECNOLOGIAS.",
                    DialogStartupLocation = WindowStartupLocation.CenterScreen,
                    Closed = (obj, args) =>
                    {
                        Shutdown();
                    }
                }); 
            }
            var mainWindow = serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }
    }
}
