using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training._02._05_Using_Interface
{
    public class PaymentManager
    {
        private readonly List<IPayment> _paymentHistory = new List<IPayment>();

        public void ProcessPayments(IPayment payment)
        {
            _paymentHistory.Add(payment);

            payment.ProcessPayment();
            Console.WriteLine("Payment Status: " + payment.GetPaymentStatus());
        }

        public void ShowPaymentHistory()
        {
            Console.WriteLine("\nPaymentHistory:");
            foreach(var payment in _paymentHistory)
            {
                Console.WriteLine(payment.GetPaymentStatus());
            }
        }
    }
}
