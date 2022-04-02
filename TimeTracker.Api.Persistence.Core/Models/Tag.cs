using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TimeTracker.Core.Models;

namespace TimeTracker.Api.Persistence.Core.Models
{
    public class Tag : ITag
    {
        [JsonConstructor]
        public Tag(User user, List<ProjectUserTag> projects)
        {
            User = user;
            Projects = (ICollection<IProjectUserTag>)projects;
        }
        public Tag()
        {

        }
        public string Description { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
        public byte[] Version { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public IUser User { get; set; }
        public int UserId { get; set; }
        public ICollection<IProjectUserTag> Projects { get; set; }
    }
}
