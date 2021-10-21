using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wolf.Utility.Core.Persistence.EntityFramework;

namespace TimeTracker.Api.Persistence.Core.EntityFrameworkCore
{
    public class TimeTrackerHandler : BaseHandler<TimeTrackerContext>
    {
        public TimeTrackerHandler(TimeTrackerContext context) : base(context)
        {
        }

        protected override Task<IQueryable<T>> AbstractFind<T>(T predicate)
        {
            throw new NotImplementedException();
        }
    }
}
