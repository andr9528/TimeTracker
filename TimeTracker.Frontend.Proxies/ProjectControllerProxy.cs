using Microsoft.AspNetCore.Mvc;

using RestSharp;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TimeTracker.Core.Controllers;
using TimeTracker.Frontend.Models;

using Wolf.Utility.Core.Persistence.EntityFramework.Core;
using Wolf.Utility.Core.Web;

namespace TimeTracker.Frontend.Proxies
{
    public class ProjectControllerProxy : EntityControllerProxy<Project>, IProjectController<Project>
    {
        public ProjectControllerProxy(string baseAddress, string controller = null) : base(baseAddress, controller)
        {
        }

        protected override RestRequest BuildGetRequestQuery(Project entity)
        {
            var req = new RestRequest();

            if (entity.Id != default)
                req.AddQueryParameter(nameof(entity.Id), entity.Id.ToString());
            if (entity.Name != default)
                req.AddQueryParameter(nameof(entity.Name), entity.Name);
            if (entity.Description != default)
                req.AddQueryParameter(nameof(entity.Description), entity.Description);

            return req;
        }
    }
}
