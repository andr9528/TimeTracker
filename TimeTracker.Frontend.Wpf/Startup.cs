
using TimeTracker.Core.Enums;
using TimeTracker.Frontend.Proxies;

using Wolf.Utility.Core.Authentication.GoogleInteraction;
using Wolf.Utility.Core.Logging;
using Wolf.Utility.Core.Startup;
using Wolf.Utility.Core.Web.Startup;
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

            AddModule(new ProxyStartupModule<ProjectControllerProxy>(Configuration, Controllers.Project.ToString()));
            AddModule(new ProxyStartupModule<ProjectUserControllerProxy>(Configuration, Controllers.ProjectUser.ToString()));
            AddModule(new ProxyStartupModule<UserControllerProxy>(Configuration, Controllers.User.ToString()));

            SetupServices();
            SetupApplication();
        }
    }
}
