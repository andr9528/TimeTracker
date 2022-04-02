using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TimeTracker.Api.Persistence.Core.Models;

using Wolf.Utility.Core.Persistence.EntityFramework.Core;

namespace TimeTracker.Api.Persistence.Core.EntityFrameworkCore.Config
{
    public class ProjectUserTagConfig : EntityConfig<ProjectUserTag>
    {
        public ProjectUserTagConfig()
        {

        }

        public override void Configure(EntityTypeBuilder<ProjectUserTag> builder)
        {
            base.Configure(builder);

            builder.HasIndex(x => new { x.ProjectId, x.TagId }, "UniqueProjectUserTagIndex").IsUnique();
        }
    }
}
