using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Strategy.Strategies
{
    public class CreditCardPaymentStrategy : IPaymentStrategy
    {
        public string Pay(double amount)
        {
            return $"{amount}$ got paid by creadit card";
        }
    }
}
