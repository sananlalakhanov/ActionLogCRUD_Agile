using AgileTask.DataAccess.Abstract;
using AgileTask.DataAccess.Concrete.Contexts;
using AgileTask.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgileTask.DataAccess.Concrete.EntityFramework
{
    public class EfActionLoggerRepository : IActionLoggerRepository
    {
        public IList<ActionLogger> GetAll(string text, DateTime? startDate, DateTime? endDate)
        {
            using (var context = new AgileTaskContext())
            {
                //return context.ActionLoggers.ToList().Skip(0).Take(20).ToList();
                var query = string.IsNullOrEmpty(text) ?
                    context.ActionLoggers :
                    context.ActionLoggers.Where(p => p.Content.ToLower().Contains(text.ToLower()));
                if (startDate != null)
                {
                    query = query.Where(dt => dt.CreatedDate >= startDate);
                }
                if (endDate.HasValue)
                {
                    query = query.Where(dt => dt.CreatedDate <= endDate);
                }

                return query.ToList();
            }
        }

    }
}
