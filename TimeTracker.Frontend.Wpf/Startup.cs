using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using Wolf.Utility.Core.Persistence.EntityFramework;
using Wolf.Utility.Core.Startup;
using Wolf.Utility.Core.Startup.Modules;
using Wolf.Utility.Core.Wpf;

namespace TimeTracker.Frontend.Wpf
{
    public class Startup : ModularStartup
    {
        public Startup() : base()
        {
            AddModule(new NLogStartupModule());
            AddModule(new WpfStartupModule<MainWindow>());

            SetupServices();
            SetupApplication();
        }
    }
}
