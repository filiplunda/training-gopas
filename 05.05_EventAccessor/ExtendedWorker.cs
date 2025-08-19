using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training._05._05_EventAccessor
{
    class ExtendedWorker: Worker
    {
        public override void DoWork()
        {
            Console.WriteLine("My Extended work");
            base.OnWorkDone(EventArgs.Empty);
        }
    }
}
