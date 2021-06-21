using AgileTask.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgileTask.Business.Abstract
{
    public interface IActionLoggerService
    {
       IList<ActionLogger> GetAll(string text,DateTime? startDate, DateTime? endDate);
    }
}
