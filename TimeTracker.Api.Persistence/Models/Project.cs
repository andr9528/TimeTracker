using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeTracker.Core.Models;

namespace TimeTracker.Api.Persistence.Models
{
    public class Project : IProject
    {
        public Project(List<ProjectUser> users, List<Resource> resources)
        {
            Users = (ICollection<IProjectUser>)users;
            Resources = (ICollection<IResource>)resources;
        }

        public ICollection<IProjectUser> Users { get; set; }
        public ICollection<IResource> Resources { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
        public byte[] Version { get; set; } 
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
