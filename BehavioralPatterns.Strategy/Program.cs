// See https://aka.ms/new-console-template for more information
using BehavioralPatterns.Strategy;
using BehavioralPatterns.Strategy.Strategies;

var paymentContext = new PaymentContext(new CashPaymentStrategy());
var message = paymentContext.MakePayment(200);
Console.WriteLine(message);

paymentContext.SetStrategy(new VoucherPaymentStrategy());
message = paymentContext.MakePayment(200);
Console.WriteLine(message);


paymentContext.SetStrategy(new CreditCardPaymentStrategy());
message = paymentContext.MakePayment(200);
Console.WriteLine(message);

Console.ReadLine();