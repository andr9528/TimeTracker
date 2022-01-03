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

using Wolf.Utility.Core.Logging;

namespace TimeTracker.Frontend.Wpf.Pages
{
    /// <summary>
    /// Interaction logic for OverviewPage.xaml
    /// </summary>
    public partial class OverviewPage : Page
    {
        private ILoggerManager logger;

        public OverviewPage(ILoggerManager logger)
        {
            InitializeComponent();
            this.logger = logger;
            logger.SetCaller(nameof(OverviewPage));

            logger.LogInfo("Ready");

            Title = "Overview";
        }
    }
}
