using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeTracker.Api.Persistence.Models;
using Wolf.Utility.Core.Persistence.EntityFramework.Core;

namespace TimeTracker.Api.Persistence.EntityFrameworkCore.Config
{
    public class ProjectConfig : EntityConfig<Project>
    {
        public ProjectConfig()
        {
        }

        public override void Configure(EntityTypeBuilder<Project> builder)
        {
            base.Configure(builder);

            builder.HasIndex(x => x.Name, "UniqueNameIndex").IsUnique();

            builder.HasMany(x => (ICollection<ProjectUser>)x.Users).WithOne(x => (Project)x.Project).HasForeignKey(x => x.ProjectId);
            builder.HasMany(x => (ICollection<Resource>)x.Resources).WithOne(x => (Project)x.Project).HasForeignKey(x => x.ProjectId);
        }
    }
}
