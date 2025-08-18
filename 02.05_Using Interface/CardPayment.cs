using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training._02._05_Using_Interface
{
    public class CardPayment: IPayment
    {
        private string status = "Payment not processed";

        void IPayment.ProcessPayment()
        {
            status = "Payment processes via card";
            Console.WriteLine("Processing card payment...");
        }

        string IPayment.GetPaymentStatus()
        {
            return status;
        }
    }
}
