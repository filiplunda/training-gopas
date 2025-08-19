using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training._05._05_EventAccessor
{
    class Worker
    {
        public event EventHandler WorkDone
        {
            add
            {
                if (handler == null)
                {
                    handler += value;
                }
                else
                {
                    throw new InvalidOperationException("Only one registration is allowed");
                }
            }
            remove { handler -= value; }
        }

        private EventHandler handler;

        public virtual void DoWork()
        {
            Console.WriteLine("Work");
            //if (WorkDone != null)
            //{
            //    WorkDone(this, EventArgs.Empty);
            //}
            OnWorkDone(EventArgs.Empty);
        }

        protected virtual void OnWorkDone(EventArgs e)
        {
            if(handler != null)
            {
                handler(this, e);
            }
        }
    }
}
