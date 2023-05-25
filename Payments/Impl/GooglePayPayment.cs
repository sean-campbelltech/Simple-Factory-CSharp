using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryPattern.Payments.Impl
{
    public class GooglePayPayment : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Successfully paid ${amount} to merchant using Google Pay.");
        }
    }
}