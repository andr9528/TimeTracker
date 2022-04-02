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
    public class TagConfig : EntityConfig<Tag>
    {
        public TagConfig()
        {

        }

        public override void Configure(EntityTypeBuilder<Tag> builder)
        {
            base.Configure(builder);

            builder.HasMany(x => (ICollection<ProjectUserTag>)x.Projects).WithOne(x => (Tag)x.Tag).HasForeignKey(x => x.TagId);
        }
    }
}
