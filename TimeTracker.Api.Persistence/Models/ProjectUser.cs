using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeTracker.Core.Models;

namespace TimeTracker.Api.Persistence.Models
{
    public class ProjectUser : IProjectUser
    {
        public ProjectUser(User user, Project project, List<Entry> entries)
        {
            User = user;
            Project = project;
            Entries = (ICollection<IEntry>)entries;
        }

        public IUser User { get; set; }
        public int UserId { get; set; }
        public IProject Project { get; set; }
        public int ProjectId { get; set; }
        public ICollection<IEntry> Entries { get; set; }
        public int Id { get; set; }
        public byte[] Version { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
