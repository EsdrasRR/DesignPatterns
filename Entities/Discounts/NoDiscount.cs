using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Entities.Discounts
{
    public class NoDiscount : IDiscount
    {
        public IDiscount NextDiscount { get; set; }

        public double Discount (ShoppingCart budget)
        {
            return 0;
        }
    }
}
