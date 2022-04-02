using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TimeTracker.Core.Models.Common;

namespace TimeTracker.Core.Models
{
    public interface ITag : ICommon
    {
        /// <summary>
        /// Owner of the Tag
        /// </summary>
        IUser User { get; set; }
        int UserId { get; set; }
        ICollection<IProjectUserTag> Projects { get; set; }
    }
}
