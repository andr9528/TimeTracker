using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeTracker.Api.Persistence.Models;
using Wolf.Utility.Core.Persistence.EntityFramework.Core;

namespace TimeTracker.Api.Persistence.EntityFrameworkCore.Config
{
    public class EntryConfig : EntityConfig<Entry>
    {
        public EntryConfig()
        {
        }

        public override void Configure(EntityTypeBuilder<Entry> builder)
        {
            base.Configure(builder);

            builder.HasIndex(x => new { x.Name, x.Description }, "UniqueEntryIndex").IsUnique();

            builder.HasMany(x => (ICollection<Pause>)x.Pauses).WithOne(x => (Entry)x.Entry).HasForeignKey(x => x.EntryId);

            builder.Property(x => x.Start).IsRequired(false);
            builder.Property(x => x.End).IsRequired(false);
        }
    }
}
