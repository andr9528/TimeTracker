using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Wolf.Utility.Core.Persistence.Core;
using Wolf.Utility.Core.Wpf.Core.Models;

namespace TimeTracker.Core.Models
{
    public interface IUserSetting : IEntity, INavigationPageConfig
    {
        IUser User { get; set; }
        int UserId { get; set; }
    }
}
