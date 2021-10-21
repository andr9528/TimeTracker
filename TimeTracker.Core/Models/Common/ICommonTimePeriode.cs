using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Wolf.Utility.Core.Persistence.Core;
namespace TimeTracker.Core.Models.Common
{
    /// <summary>
    /// Should rarely be implemented directly.
    /// More commonly <see cref="IEntry"/> or <see cref="IPause"/> is the one to be implemented./>
    /// </summary>
    public interface ICommonTimePeriode : ICommon
    {
        DateTime? Start { get; set; }
        DateTime? End { get; set; }
    }
}
