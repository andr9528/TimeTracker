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
using Wolf.Utility.Core.Wpf.Controls;

namespace TimeTracker.Frontend.Wpf.Pages
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        private ILoggerManager logger;
        private SignInButton<GoogleProfile> googleSignIn;

        public LoginPage(ILoggerManager logger)
        {
            InitializeComponent();
            this.logger = logger;
            logger.SetCaller(nameof(LoginPage));

            logger.LogInfo("Ready");

            Title = "Login";
        }

        public Task Init(Action<GoogleProfile> action, IServiceProvider provider)
        {
            Dispatcher.Invoke(() =>
            {
                try
                {
                    googleSignIn = new SignInButton<GoogleProfile>(action, provider) { Margin = new Thickness(40) };
                    Grid.SetRow(googleSignIn, 2);
                    Grid.SetColumn(googleSignIn, 0);
                    LoginGrid.Children.Add(googleSignIn);
                }
                catch (Exception e)
                {
                    logger?.LogError(e.ToString());
                    throw;
                }
            });
            return Task.CompletedTask;
        }
    }
}