using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeTracker.Core.Enums;
using TimeTracker.Core.Models;

namespace TimeTracker.Api.Persistence.Core.Models
{
    public class User : IUser
    {
        [JsonConstructor]
        public User(List<ProjectUser> projects, List<Tag> tags, UserSetting setting)
        {
            Projects = (ICollection<IProjectUser>)projects;
            Tags = (ICollection<ITag>)tags;
            Setting = setting;
        }

        public User()
        {

        }

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
