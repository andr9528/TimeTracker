
using Wolf.Utility.Core.Authentication.GoogleInteraction;
using Wolf.Utility.Core.Logging;
using Wolf.Utility.Core.Startup;
using Wolf.Utility.Core.Wpf.Startup;

namespace TimeTracker.Frontend.Wpf
{
    public class Startup : ModularStartup
    {
        public Startup() : base()
        {
            AddModule(new NLogStartupModule());
            AddModule(new WpfStartupModule<MainWindow>());
            AddModule(new GoogleLoginStartupModule(Configuration));

            SetupServices();
            SetupApplication();
        }
    }
}
