using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Entities.Discounts
{
    public class FiveHundredDollarsOrMore : IDiscount
    {
        public IDiscount NextDiscount { get; set; }

        public double Discount(ShoppingCart shoppingCart)
        {
            if (shoppingCart.Itens.Sum(x => x.Value) >= 500)
            {
                return shoppingCart.Value * 0.07;
            }
            else
            {
                return NextDiscount.Discount(shoppingCart);
            }
        }
    }
}
