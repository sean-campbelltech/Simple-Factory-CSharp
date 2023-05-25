using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryPattern.Payments.Enums;
using FactoryPattern.Payments.Impl;

namespace FactoryPattern.Payments
{
    public class PaymentFactory
    {
        public static IPayment create(PaymentMethod paymentMethod) 
        {
            switch(paymentMethod) 
            {
                case PaymentMethod.CreditCard:
                    return new CreditCardPayment();
                    
                case PaymentMethod.PayPal:
                    return new PayPalPayment();
                
                case PaymentMethod.GooglePay:
                    return new GooglePayPayment();
                
                case PaymentMethod.ApplePay:
                    return new ApplePayPayment();

                default:
                    throw new NotSupportedException(
                        $"{paymentMethod} is not currently supported as a payment method."
                    );
            }
        }
    }
}