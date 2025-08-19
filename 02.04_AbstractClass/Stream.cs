using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training._02._04_AbstractClass
{
    abstract class Stream
    {
        public void Close()
        {
            Console.WriteLine("Closing Stream");
        }

        public abstract void Open();
    }
}
