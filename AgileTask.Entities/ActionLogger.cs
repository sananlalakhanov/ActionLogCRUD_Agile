using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AgileTask.Entities
{
    [Table("ACTION_LOGGER")]
    public class ActionLogger
    {
        [Column("ID")]
        public string Id { get; set; }
        [Column("CREATED_DATE")]
        public DateTime CreatedDate { get; set; }
        [Column("CONTENT")]
        public string Content { get; set; }
        public ActionLogger()
        {
            CreatedDate = DateTime.Now;
        }
    }
}
