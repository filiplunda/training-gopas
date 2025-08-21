using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training._07._03_IEnumerable
{
    static class IEnumerableExtender
    {
        public static IEnumerable<T> MyFindAll<T>(this IEnumerable<T> list, Predicate<T> fn)
        {
            List<T> result = new List<T>();
            foreach(var item in list)
            {
                if (fn(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }
    }
}
