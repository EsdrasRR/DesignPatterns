using DesignPatterns.Entities;
using DesignPatterns.Entities.Discounts;
using DesignPatterns.Interfaces;

namespace DesignPatterns.Service
{
    public class DiscountCalculator
    {
        public double Calculate(ShoppingCart shoppingCart)
        {
            IDiscount fiveHundredDollarsOrMore = new FiveHundredDollarsOrMore();
            IDiscount fiveItensOrMore = new FiveItemsOrMore();
            IDiscount noDiscount = new NoDiscount();

            fiveHundredDollarsOrMore.NextDiscount = fiveItensOrMore;
            fiveItensOrMore.NextDiscount = noDiscount;

            return fiveHundredDollarsOrMore.Discount(shoppingCart);
        }
    }
}
