﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Strategy.Strategies
{
    public interface IPaymentStrategy
    {
        string Pay(double amount);
    }
}
