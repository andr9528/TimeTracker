using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Core.Models.Common;
using Wolf.Utility.Core.Persistence.Core;

namespace TimeTracker.Core.Models
{
    public interface IEntry : ICommonTimePeriode
    {
        ICollection<IPause> Pauses { get; set; }
        IProjectUser ProjectUser { get; set; }
        int ProjectUserId { get; set; }
    }
}
