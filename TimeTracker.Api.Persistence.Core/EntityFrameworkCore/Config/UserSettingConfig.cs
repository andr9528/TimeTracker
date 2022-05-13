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
    public class UserSettingConfig : EntityConfig<UserSetting>
    {
        public UserSettingConfig()
        {

        }
        public override void Configure(EntityTypeBuilder<UserSetting> builder)
        {
            base.Configure(builder);


        }
    }
}
