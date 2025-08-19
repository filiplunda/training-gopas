using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training._03._01_GenericTypes
{
    public class GenericClass<T>
    {
        //T item;
        
        public T GetValue()
        {
            T item = default(T);
            return item;
        }
    }
}
