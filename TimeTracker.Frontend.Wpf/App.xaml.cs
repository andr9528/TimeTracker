using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;

namespace TimeTracker.Frontend.Wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Startup StartupConfig;

        public App()
        {
            StartupConfig = new Startup();
        }

        private void OnStartup(object sender, StartupEventArgs e)
        {
            var mainWindow = StartupConfig.ServiceProvider.GetService<MainWindow>();            
            mainWindow.Show();
        }
    }
}
