using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using TimeTracker.Api.Persistence.Core.Models;
using Wolf.Utility.Core.Persistence.EntityFramework.Core;

namespace TimeTracker.Api.Persistence.Core.EntityFrameworkCore.Config
{
    public class ProjectUserConfig : EntityConfig<ProjectUser>
    {
        public ProjectUserConfig()
        {
        }

        public override void Configure(EntityTypeBuilder<ProjectUser> builder)
        {
            base.Configure(builder);

            builder.HasIndex(x => new { x.ProjectId, x.UserId }, "UniqueProjectUserIndex").IsUnique();

            builder.HasMany(x => (ICollection<Entry>)x.Entries).WithOne(x => (ProjectUser)x.ProjectUser).HasForeignKey(x => x.ProjectUserId);
            builder.HasMany(x => (ICollection<ProjectUserTag>)x.Tags).WithOne(x => (ProjectUser)x.Project).HasForeignKey(x => x.ProjectId);
        }
    }
}
