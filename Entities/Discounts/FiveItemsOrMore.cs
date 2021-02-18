using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Entities.Discounts
{
    public class FiveItemsOrMore : IDiscount
    {
        public IDiscount NextDiscount { get; set; }
        public double Discount(ShoppingCart budget)
        {
            if (budget.Itens.Count >= 5)
            {
                return budget.Value * 0.1;
            }
            else
            {
                return NextDiscount.Discount(budget);
            }
        }
    }
}
