using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Core.Models;
using Wolf.Utility.Core.Web;

namespace TimeTracker.Core.Controllers
{
    public interface IProjectUserController<TEntity> : IAdvancedController<TEntity> where TEntity : class, IProjectUser
    {
    }
}
