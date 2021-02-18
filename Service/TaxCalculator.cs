using DesignPatterns.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class TaxCalculator
    {
        public void PerformsCalculation(Account account, ITaxation taxation)
        {
            double result = taxation.Calculator(account);
            var type = taxation.GetType(); 
            Console.WriteLine($"{type.Name} tax value: ${result}");
        }

    }
}
