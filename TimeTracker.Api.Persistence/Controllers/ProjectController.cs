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
    public class ProjectController : AdvancedController<Project>, IProjectController<Project>
    {
        private readonly IHandler handler;
        private readonly ILoggerManager logger;

        public ProjectController(IHandler handler, ILoggerManager logger) : base(handler)
        {
            this.handler = handler;
            this.logger = logger;
            logger.SetCaller(nameof(ProjectController));
        }

        public override async Task<IActionResult> Delete(Project data)
        {
            throw new NotImplementedException();
        }

        public override async Task<ActionResult<IEnumerable<Project>>> Get([FromQuery] Project entity)
        {
            throw new NotImplementedException();
        }

        public override async Task<ActionResult<Project>> Post(Project data)
        {
            throw new NotImplementedException();
        }

        public override async Task<ActionResult<Project>> Put(Project data)
        {
            throw new NotImplementedException();
        }
    }
}
