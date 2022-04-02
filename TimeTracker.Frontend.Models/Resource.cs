using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TimeTracker.Core.Models;

namespace TimeTracker.Frontend.Models
{
    public class Resource : IResource
    {
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
