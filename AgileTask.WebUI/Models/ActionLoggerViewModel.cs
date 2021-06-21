using AgileTask.Entities;
using System.Collections.Generic;

namespace AgileTask.WebUI.Models
{
    public class ActionLoggerViewModel
    {
        public List<ActionLogger> ActionLoggers { get; set; }
        public int totalRecord { get; set; }
        public int pageNo { get; set; }
        public int pageSize { get; set; }

    }
}
