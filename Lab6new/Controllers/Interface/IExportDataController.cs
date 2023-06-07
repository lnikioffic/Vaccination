using Lab6new.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6new.Controllers.Interface
{
    internal interface IExportDataController<T>
        where T : class,IModel
    {
        public List<T> GetData(Predicate<T> filter, Func<T, object> sort, bool descending = false);
    }
}
