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
    public class ProjectUserController : AdvancedController<ProjectUser>, IProjectUserController<ProjectUser>
    {
        private readonly IHandler handler;
        private readonly ILoggerManager logger;

        public ProjectUserController(IHandler handler, ILoggerManager logger) : base(handler)
        {
            this.handler = handler;
            this.logger = logger;
            logger.SetCaller(nameof(ProjectUserController));
        }

        public override Task<IActionResult> Delete(ProjectUser entity)
        {
            throw new NotImplementedException();
        }

        public override Task<ActionResult<IEnumerable<ProjectUser>>> Get(ProjectUser entity)
        {
            throw new NotImplementedException();
        }

        public override Task<ActionResult<ProjectUser>> Post(ProjectUser entity)
        {
            throw new NotImplementedException();
        }

        public override Task<ActionResult<ProjectUser>> Put(ProjectUser entity)
        {
            throw new NotImplementedException();
        }
    }
}
