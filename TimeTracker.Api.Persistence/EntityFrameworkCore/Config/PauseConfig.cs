using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeTracker.Api.Persistence.Models;
using Wolf.Utility.Core.Persistence.EntityFramework.Core;

namespace TimeTracker.Api.Persistence.EntityFrameworkCore.Config
{
    public class PauseConfig : EntityConfig<Pause>
    {
        public PauseConfig()
        {
        }

        public override void Configure(EntityTypeBuilder<Pause> builder)
        {
            base.Configure(builder);

            builder.HasIndex(x => new { x.Name, x.Description, x.EntryId }, "UniquePauseIndex").IsUnique();

            builder.Property(x => x.Start).IsRequired(false);
            builder.Property(x => x.End).IsRequired(false);
        }
    }
}
