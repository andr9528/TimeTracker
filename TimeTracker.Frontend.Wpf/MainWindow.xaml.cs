using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using TimeTracker.Frontend.Wpf.Pages;

using Wolf.Utility.Core.Logging;
using Wolf.Utility.Core.Wpf.Controls;
using Wolf.Utility.Core.Wpf.Controls.Model;
using Wolf.Utility.Core.Wpf.Core.Enums;

namespace TimeTracker.Frontend.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ILoggerManager logger;
        private readonly NavigationPage navigation;

        public MainWindow(ILoggerManager logger)
        {
            InitializeComponent();
            this.logger = logger;
            logger.SetCaller(nameof(MainWindow));

            logger.LogInfo("Ready");
        }

        public void Init() => Task.Run(async () => await CreateNavigationPage());

        public async Task CreateNavigationPage()
        {
            await Dispatcher.Invoke(async () =>
            {
                var pages = new List<NavigationInfo>();

                var loginLogger = App.StartupConfig.ServiceProvider.GetService<ILoggerManager>();
                var loginPage = new LoginPage(loginLogger);
                await loginPage.Init();
                var loginInfo = new NavigationInfo(loginPage);
                pages.Add(loginInfo);

                var overviewLogger = App.StartupConfig.ServiceProvider.GetService<ILoggerManager>();
                var overviewPage = new OverviewPage(overviewLogger);
                var overviewInfo = new NavigationInfo(overviewPage);
                pages.Add(overviewInfo);

                var addProjectLogger = App.StartupConfig.ServiceProvider.GetService<ILoggerManager>();
                var addProjectPage = new AddProjectPage(addProjectLogger);
                var addProjectInfo = new NavigationInfo(addProjectPage);
                pages.Add(addProjectInfo);

                var navPageLogger = App.StartupConfig.ServiceProvider.GetService<ILoggerManager>();
                var navigation = new NavigationPage(pages, navPageLogger, NavigationLocation.Left)
                { HorizontalAlignment = HorizontalAlignment.Stretch, VerticalAlignment = VerticalAlignment.Stretch };

                MainFrame.Content = navigation;
            });
        }
    }
}
