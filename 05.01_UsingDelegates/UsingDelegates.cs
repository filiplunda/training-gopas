using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training._05._01_UsingDelegates
{
    class UsingDelegates
    {
        internal delegate int MyDelegate(int a, int b);

        internal delegate void MyAnotherDelegate();

        public delegate void WorkCompletedCallBack(string result);

        public delegate void DownloadCompletedCallBack(string result);
    }
}
