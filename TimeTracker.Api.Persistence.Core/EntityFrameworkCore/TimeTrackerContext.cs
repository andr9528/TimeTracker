using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

using TimeTracker.Api.Persistence.Core.EntityFrameworkCore.Config;
using Wolf.Utility.Core.Persistence.EntityFramework;

namespace TimeTracker.Api.Persistence.Core.EntityFrameworkCore
{
    public class TimeTrackerContext : BaseContext
    {
        public TimeTrackerContext([NotNull] DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new EntryConfig());
            modelBuilder.ApplyConfiguration(new PauseConfig());
            modelBuilder.ApplyConfiguration(new ProjectConfig());
            modelBuilder.ApplyConfiguration(new ProjectUserConfig());
            modelBuilder.ApplyConfiguration(new ResourceConfig());
            modelBuilder.ApplyConfiguration(new UserConfig());
        }
    }
}
