// See https://aka.ms/new-console-template for more information
using FactoryPattern;
using FactoryPattern.Payments;
using FactoryPattern.Payments.Enums;

IPayment payment = PaymentFactory.create(PaymentMethod.ApplePay);
payment.Pay(1000.00);
