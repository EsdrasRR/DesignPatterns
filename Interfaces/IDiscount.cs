using DesignPatterns.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Interfaces
{
    public interface IDiscount
    {
        double Discount(ShoppingCart shoppingCart);
        IDiscount NextDiscount { get; set; }
    }
}
