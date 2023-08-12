using BehavioralPatterns.Strategy.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Strategy
{
    public class PaymentContext
    {
        private IPaymentStrategy _paymentStrategy;

        public PaymentContext(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void SetStrategy(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public string MakePayment(double amount)
        {
            var paymentMessage = "Payment type selected\n";
            paymentMessage += _paymentStrategy.Pay(amount);
            return paymentMessage;
        }
    }
}
