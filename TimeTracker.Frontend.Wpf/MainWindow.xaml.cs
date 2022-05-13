using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.ComponentModel;
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

using TimeTracker.Frontend.Models;
using TimeTracker.Frontend.Proxies;
using TimeTracker.Frontend.Wpf.Pages;
using TimeTracker.Frontend.Wpf.ViewModel;

using Wolf.Utility.Core.Authentication.GoogleInteraction;
using Wolf.Utility.Core.Logging;
using Wolf.Utility.Core.Web;
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
        private readonly MainWindowModel model;
        private LoginPage loginPage;

        public MainWindow(ILoggerManager logger)
        {
            InitializeComponent();
            this.logger = logger;
            logger.SetCaller(nameof(MainWindow));

            model = new MainWindowModel();
            CreateNavigationPage();
            model.PropertyChanged += Model_PropertyChanged;

            logger.LogInfo("Ready");
        }

        private void Model_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(model.IsAuthenticated)) Model_IsAuthenticatedChanged(sender, e);
        }

        private void Model_IsAuthenticatedChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (model.IsAuthenticated)
            {
                case true:
                    SetActivePage(navigation);
                    break;

                case false:
                    SetActivePage(loginPage);
                    break;
            }
        }

        public void Init() => Task.Run(async () => await InitializeLogin());

        private async Task InitializeLogin()
        {
            await Dispatcher.Invoke(async () =>
            {
                var loginLogger = App.StartupConfig.ServiceProvider.GetService<ILoggerManager>();
                loginPage = new LoginPage(loginLogger);
                await loginPage.Init(LoginAction, App.StartupConfig.ServiceProvider);
                MainFrame.Content = loginPage;
            });
        }

        /// <summary>
        /// Called on the Login Page, when a SignIn button is clicked, and signin is succesful.
        /// </summary>
        /// <param name="input"></param>
        private void LoginAction(GoogleProfile input)
        {
            logger.LogDebug($"Retrieved User info: {input}");

            GetUser(input);
        }

        private async Task GetUser(GoogleProfile info)
        {
            var proxy = App.StartupConfig.ServiceProvider.GetService<IEntityControllerProxy<User>>();

            model.User = await proxy.GetOrAddEntity(new User() { AccountId = info.Id });

            model.IsAuthenticated = true;
        }

        private Task CreateNavigationPage()
        {
            var pages = new List<NavigationInfo>();

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

            return Task.CompletedTask;
        }

        private Task SetActivePage(Page page)
        {
            Dispatcher.Invoke(() =>
            {
                MainFrame.Content = page;
            });
            return Task.CompletedTask;
        }
    }
}