using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeTracker.Core.Models;

namespace TimeTracker.Api.Persistence.Core.Models
{
    public class Entry : IEntry
    {
        public Entry(List<Pause> pauses, ProjectUser projectUser)
        {
            Pauses = (ICollection<IPause>)pauses;
            ProjectUser = projectUser;
        }

        public Entry()
        {

        }

        public ICollection<IPause> Pauses { get; set; }
        public IProjectUser ProjectUser { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
        public byte[] Version { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int ProjectUserId { get; set; }
    }
}
