using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TimeTracker.Api.Persistence.Core.EntityFrameworkCore;

using Wolf.Utility.Core.Logging;
using Wolf.Utility.Core.Persistence.EntityFramework;
using Wolf.Utility.Core.Startup;
using Wolf.Utility.Core.Startup.Modules;

namespace TimeTracker.Api.Persistence
{
    public class Startup : ModularStartup
    {
        private const string CONNECTIONSTRINGNAME = "mainDb";
        public Startup(IConfiguration configuration) : base(configuration)
        {
            AddModule(new NLogStartupModule());
            AddModule(new SwaggerStartupModule());
            AddModule(new EntityFrameworkStartupModule<TimeTrackerContext, TimeTrackerHandler>(
                options => options.UseSqlite(Configuration.GetConnectionString(CONNECTIONSTRINGNAME))));
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            SetupServices(services);

            services.AddControllers();            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            SetupApplication(app);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });            
        }
    }
}
