using AgileTask.Business.Abstract;
using AgileTask.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace AgileTask.WebUI.Controllers
{
    public class ActionLoggerController : Controller
    {
        private readonly IActionLoggerService _actionLoggerService;
        public ActionLoggerController(IActionLoggerService actionLoggerService)
        {
            _actionLoggerService = actionLoggerService;
        }
        public IActionResult Index(string content, int p = 1, int s = 20, DateTime? startDate = null, DateTime? endDate = null)
        {

            var model = new ActionLoggerViewModel
            {
                ActionLoggers = _actionLoggerService.GetAll(content, startDate, endDate).Skip((p - 1) * s).Take(s).ToList(),
                pageSize = s,
                totalRecord = _actionLoggerService.GetAll(content,startDate,endDate).Count,
                pageNo = p
            };
            return View(model);

        }
        //public IActionResult GetAll(string content)
        //{
        //    var list = _actionLoggerService.GetAll(content,startDate,endDate);
        //    return Json(list);
        //}
        //public IActionResult SearchByDate(DateTime startDate, DateTime endDate)
        //{
        //    return View(_actionLoggerService.GetByDate(startDate, endDate));
        //}
    }
}
