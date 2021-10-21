using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeTracker.Api.Persistence.Core.Models;
using Wolf.Utility.Core.Persistence.EntityFramework.Core;

namespace TimeTracker.Api.Persistence.Core.EntityFrameworkCore.Config
{
    public class UserConfig : EntityConfig<User>
    {
        public UserConfig()
        {
        }

        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            builder.HasIndex(x => new { x.AccountId, x.AccountType }, "UniqueUserIndex").IsUnique();

            builder.HasMany(x => (ICollection<ProjectUser>)x.Projects).WithOne(x => (User)x.User).HasForeignKey(x => x.UserId);
        }
    }
}
