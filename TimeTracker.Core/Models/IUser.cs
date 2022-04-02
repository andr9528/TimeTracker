using System;
using System.Collections.Generic;
using System.Text;
using TimeTracker.Core.Enums;
using TimeTracker.Core.Models.Common;
using Wolf.Utility.Core.Persistence.Core;

namespace TimeTracker.Core.Models
{
    public interface IUser : ICommon
    {
        AccountType AccountType { get; set; }
        string AccountId { get; set; }
        ICollection<ITag> Tags { get; set; }
        ICollection<IProjectUser> Projects { get; set; }
    }
}
