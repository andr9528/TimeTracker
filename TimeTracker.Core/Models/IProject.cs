using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Core.Models.Common;


namespace TimeTracker.Core.Models
{
    public interface IProject : ICommon
    {
        ICollection<IProjectUser> Users { get; set; }
        ICollection<IResource> Resources { get; set; }
    }
}
