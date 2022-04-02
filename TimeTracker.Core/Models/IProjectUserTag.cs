using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Wolf.Utility.Core.Persistence.Core;

namespace TimeTracker.Core.Models
{
    public interface IProjectUserTag : IEntity
    {
        IProjectUser Project { get; set; }
        int ProjectId { get; set; }
        ITag Tag { get; set; }
        int TagId { get; set; }
    }
}
