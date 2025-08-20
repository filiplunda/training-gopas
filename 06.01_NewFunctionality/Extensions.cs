using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training._06._01_NewFunctionality
{
    static class Extensions
    {
        public static void Add(this Stack<string> s, string value)
        {
            s.Push(value);
        }

        public static void Add<T>(this Stack<T> s, T value)
        {
            s.Push(value);
        }
    }
}
