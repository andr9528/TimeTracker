using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TimeTracker.Core.Models;

using Wolf.Utility.Core.Wpf.Core.Enums;

namespace TimeTracker.Frontend.Models
{
    public class UserSetting : IUserSetting
    {
        public int Id { get; set; }
        public byte[] Version { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool StartHidden { get; set; }
        public NavigationLocation NavigationLocation { get; set; }
        public IUser User { get; set; }
        public int UserId { get; set; }
    }
}
