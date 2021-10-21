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
    public class ProjectController : AdvancedController<Project>, IProjectController<Project>
    {
        public ProjectController(IHandler handler, ILoggerManager logger) : base(handler, logger)
        {
            logger.SetCaller(nameof(ProjectController));
        }       
    }
}
