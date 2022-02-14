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
using System.Windows.Navigation;
using System.Windows.Shapes;

using Wolf.Utility.Core.Authentication.GoogleInteraction;
using Wolf.Utility.Core.Logging;

namespace TimeTracker.Frontend.Wpf.Pages
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        private ILoggerManager logger;

        public LoginPage(ILoggerManager logger)
        {
            InitializeComponent();
            this.logger = logger;
            logger.SetCaller(nameof(LoginPage));

            logger.LogInfo("Ready");

            Title = "Login";
        }

        public async Task Init() 
        {
            var googleAuth = App.StartupConfig.ServiceProvider.GetService<GoogleProxy>();
            await googleAuth.GetProfileInfo();
        }
    }
}
