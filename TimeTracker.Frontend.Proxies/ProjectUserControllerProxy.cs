using RestSharp;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TimeTracker.Core.Controllers;
using TimeTracker.Frontend.Models;

using Wolf.Utility.Core.Web;

namespace TimeTracker.Frontend.Proxies
{
    public class ProjectUserControllerProxy : EntityControllerProxy<ProjectUser>, IProjectUserController<ProjectUser>
    {
        public ProjectUserControllerProxy(string baseAddress, string controller = null) : base(baseAddress, controller)
        {
        }

        protected override RestRequest BuildGetRequestQuery(ProjectUser entity)
        {
            var req = new RestRequest();

            if (entity.Id != default)
                req.AddQueryParameter(nameof(entity.Id), entity.Id.ToString());
            if (entity.UserId != default)
                req.AddQueryParameter(nameof(entity.UserId), entity.UserId.ToString());
            if (entity.ProjectId != default)
                req.AddQueryParameter(nameof(entity.ProjectId), entity.ProjectId.ToString());

            return req;
        }
    }
}
