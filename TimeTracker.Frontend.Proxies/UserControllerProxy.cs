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
    public class UserControllerProxy : EntityControllerProxy<User>, IUserController<User>
    {
        public UserControllerProxy(string baseAddress, string controller = null) : base(baseAddress, controller)
        {
        }

        protected override RestRequest BuildGetRequestQuery(User entity)
        {
            var req = new RestRequest();

            if (entity.Id != default)
                req.AddQueryParameter(nameof(entity.Id), entity.Id.ToString());
            if (entity.Name != default)
                req.AddQueryParameter(nameof(entity.Name), entity.Name);
            if (entity.Description != default)
                req.AddQueryParameter(nameof(entity.Description), entity.Description);
            if (entity.AccountId != default)
                req.AddQueryParameter(nameof(entity.AccountId), entity.AccountId);
            if (entity.AccountType != default)
                req.AddQueryParameter(nameof(entity.AccountType), ((int)entity.AccountType).ToString());

            return req;
        }
    }
}
