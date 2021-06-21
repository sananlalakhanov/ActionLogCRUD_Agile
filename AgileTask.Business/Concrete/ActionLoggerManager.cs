using AgileTask.Business.Abstract;
using AgileTask.DataAccess.Abstract;
using AgileTask.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgileTask.Business.Concrete
{
    public class ActionLoggerManager : IActionLoggerService
    {
        private readonly IActionLoggerRepository _actionLoggerRepository;
        public ActionLoggerManager(IActionLoggerRepository actionLoggerRepository)
        {
            _actionLoggerRepository = actionLoggerRepository;
        }
        public IList<ActionLogger> GetAll(string text,DateTime? startDate,DateTime? endDate)
        {
            return _actionLoggerRepository.GetAll(text, startDate, endDate);
        }
    }
}
 