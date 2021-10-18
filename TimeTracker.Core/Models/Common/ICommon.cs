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
    /// More commonly <see cref="IUser"/>, <see cref="IProject"/> or <see cref="IResource"/> is the one to be implemented./>
    /// </summary>
    public interface ICommon : IEntity
    {
        string Description { get; set; }
        string Name { get; set; }
    }
}
