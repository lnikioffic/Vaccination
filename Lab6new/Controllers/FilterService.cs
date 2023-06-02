using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6new.Controllers
{
    internal static class FilterService
    {
        public static Predicate<T1> GlueFilters<T1>(List<Predicate<T1>> predicates)
        {
            return delegate (T1 item)
            {
                foreach (Predicate<T1> predicate in predicates)
                {
                    if (!predicate(item))
                    {
                        return false;
                    }
                }
                return true;
            };
        }
    }
}
