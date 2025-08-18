using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training._02._05_Using_Interface
{
    public interface IPayment
    {
        void ProcessPayment();

        string GetPaymentStatus();
    }
}
