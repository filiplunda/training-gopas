using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training._02._05_Using_Interface
{
    public class BankTransferPayment: IPayment
    {
        private string status = "Payment not processed";

        public void ProcessPayment()
        {
            status = "Payment processes via bank transfer";
            Console.WriteLine("Processing bank transfer payment...");
        }

        public string GetPaymentStatus()
        {
            return status;
        }
    }
}
