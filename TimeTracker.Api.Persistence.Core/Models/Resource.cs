using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeTracker.Core.Models;

namespace TimeTracker.Api.Persistence.Core.Models
{
    public class Resource : IResource
    {
        [JsonConstructor]
        public Resource(Project project)
        {
            Project = project;
        }

        public Resource()
        {

        }

        public string Link { get; set; }
        public IProject Project { get; set; }
        public int ProjectId { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
        public byte[] Version { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
