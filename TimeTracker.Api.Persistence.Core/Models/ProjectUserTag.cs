using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TimeTracker.Core.Models;

namespace TimeTracker.Api.Persistence.Core.Models
{
    public class ProjectUserTag : IProjectUserTag
    {
        [JsonConstructor]
        public ProjectUserTag(ProjectUser project, Tag tag)
        {
            Project = project;
            Tag = tag;
        }
        public ProjectUserTag()
        {

        }

        public IProjectUser Project { get; set; }
        public int ProjectId { get; set; }
        public ITag Tag { get; set; }
        public int TagId { get; set; }
        public int Id { get; set; }
        public byte[] Version { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
