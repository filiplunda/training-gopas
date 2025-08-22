using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training._11._01_ResourceManagement
{
    class ResourceFileStream: IDisposable
    {
        public void Open()
        {
            Console.WriteLine("Opening file");
        }

        public void Close()
        {
            this.Dispose();
        }

        public void Dispose()
        {
            //Console.WriteLine("Closing file");
            //GC.SuppressFinalize(this);
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~ResourceFileStream()
        {
            //this.Dispose();
            Dispose(false);
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if ((!this.disposed))
            {
                //if we explicitly call the Dispose() method,
                //we can also reference the resources of objects that implement the 
                //IDisposable interface whose reference we hold.
                if (disposing)
                {
                    //We release the so-called managed resources.
                    //componenet.Dispose();
                    Console.WriteLine("Releasing managed resource");
                }

                Console.WriteLine("Releasing unmanaged resource");
                this.disposed = true;
            }
        }
    }
}
