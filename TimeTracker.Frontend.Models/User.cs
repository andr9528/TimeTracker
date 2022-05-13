using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TimeTracker.Core.Enums;
using TimeTracker.Core.Models;

namespace TimeTracker.Frontend.Models
{
    public class User : IUser
    {
        public AccountType AccountType { get; set; }
        public string AccountId { get; set; }
        public ICollection<IProjectUser> Projects { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
        public byte[] Version { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public ICollection<ITag> Tags { get; set; }
        public IUserSetting Setting { get; set; }
        public int SettingId { get; set; }
    }
}
