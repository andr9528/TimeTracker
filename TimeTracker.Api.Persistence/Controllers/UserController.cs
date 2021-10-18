using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeTracker.Api.Persistence.Models;
using TimeTracker.Core.Controllers;
using Wolf.Utility.Core.Logging;
using Wolf.Utility.Core.Persistence.EntityFramework.Core;
using Wolf.Utility.Core.Web;

namespace TimeTracker.Api.Persistence.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : AdvancedController<User>, IUserController<User>
    {
        private readonly IHandler handler;
        private readonly ILoggerManager logger;

        public UserController(IHandler handler, ILoggerManager logger) : base(handler)
        {
            this.handler = handler;
            this.logger = logger;
            logger.SetCaller(nameof(UserController));
        }

        public override Task<IActionResult> Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public override Task<ActionResult<IEnumerable<User>>> Get(User entity)
        {
            throw new NotImplementedException();
        }

        public override Task<ActionResult<User>> Post(User entity)
        {
            throw new NotImplementedException();
        }

        public override Task<ActionResult<User>> Put(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
