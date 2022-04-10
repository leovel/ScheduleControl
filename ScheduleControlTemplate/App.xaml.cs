using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ScheduleControlTemplate.Data.Infrastructure;
using ScheduleControlTemplate.Data.Services;
using ScheduleControlTemplate.ViewModels;
using ScheduleControlTemplate.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ScheduleControlTemplate
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            ServiceCollection services = new();
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

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var mainWindow = serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }

    }
}
