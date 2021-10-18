using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wolf.Utility.Core.Persistence.Core;

namespace TimeTracker.Core.Models
{
    public interface IProjectUser : IEntity
    {
        IUser User { get; set; }
        int UserId { get; set; }
        IProject Project { get; set; }
        int ProjectId { get; set; }
        ICollection<IEntry> Entries { get; set; }
    }
}
