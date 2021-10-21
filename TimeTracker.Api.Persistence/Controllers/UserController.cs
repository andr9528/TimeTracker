using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using TimeTracker.Api.Persistence.Core.Models;
using TimeTracker.Core.Controllers;

using Wolf.Utility.Core.Exceptions;
using Wolf.Utility.Core.Logging;
using Wolf.Utility.Core.Persistence.EntityFramework.Core;
using Wolf.Utility.Core.Web;

namespace TimeTracker.Api.Persistence.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : AdvancedController<User>, IUserController<User>
    {
        public UserController(IHandler handler, ILoggerManager logger) : base(handler, logger)
        { 
            Logger.SetCaller(nameof(UserController));
        }
    }
}
