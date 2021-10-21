using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using TimeTracker.Api.Persistence.Core.Models;
using Wolf.Utility.Core.Persistence.EntityFramework.Core;

namespace TimeTracker.Api.Persistence.Core.EntityFrameworkCore.Config
{
    public class ResourceConfig : EntityConfig<Resource>
    {
        public ResourceConfig()
        {
        }

        public override void Configure(EntityTypeBuilder<Resource> builder)
        {
            base.Configure(builder);

            builder.HasIndex(x => new { x.Name, x.ProjectId, x.Link }, "UniqueResourceIndex").IsUnique();
        }
    }
}
