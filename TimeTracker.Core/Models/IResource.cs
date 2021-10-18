using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Core.Models.Common;


namespace TimeTracker.Core.Models
{
    public interface IResource : ICommon
    {
        string Link { get; set; }
        IProject Project { get; set; }
        int ProjectId { get; set; }
    }
}
