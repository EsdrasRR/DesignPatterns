using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class ICMS : ITaxation
    {
        public double Calculator(Budget budget)
        {
            return budget.Value * 0.06;
        }
    }
}
