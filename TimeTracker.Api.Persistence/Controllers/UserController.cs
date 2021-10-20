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

        public override async Task<IActionResult> Delete(User entity)
        {
            var result = await handler.Delete(entity);

            if (result) return new OkResult();
            return new StatusCodeResult(304); // Returns Status code 304, Not Modified.
        }

        public override async Task<ActionResult<IEnumerable<User>>> Get([FromQuery]User entity)
        {
            var result = await handler.FindMultiple(entity);

            return new OkObjectResult(result);
        }

        public override async Task<ActionResult<User>> Post(User entity)
        {
            throw new NotImplementedException();
        }

        public override async Task<ActionResult<User>> Put(User entity)
        {
            var result = await handler.UpdateAndRetrieve(entity);

            return new OkObjectResult(result);
        }
    }
}
