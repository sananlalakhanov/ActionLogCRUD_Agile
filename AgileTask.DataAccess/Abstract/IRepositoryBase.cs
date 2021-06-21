using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgileTask.DataAccess.Abstract
{
    public interface IRepositoryBase<T>
        where T:class,new()
    {
        IList<T> GetAll(string text, DateTime? startDate, DateTime? endDate);
    }
}
