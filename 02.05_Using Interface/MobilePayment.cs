using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training._02._05_Using_Interface
{
    public class MobilePayment : IPayment
    {
        private string status = "Payment not processed";

        public void ProcessPayment()
        {
            status = "Payment processes via mobile app";
            Console.WriteLine("Processing mobile payment...");
        }

        public string GetPaymentStatus()
        {
            return status;
        }
    }
}
