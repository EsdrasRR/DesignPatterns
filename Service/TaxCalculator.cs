using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class TaxCalculator
    {
        public void PerformsCalculation(Budget budget, ITaxation taxation)
        {
            double result = taxation.Calculator(budget);
            var type = taxation.GetType(); 
            Console.WriteLine($"{type.Name} tax value: ${result}");
        }

    }
}
