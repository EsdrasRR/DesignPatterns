using DesignPatterns.Entities;
using DesignPatterns.Service;
using DesignPatterns.Tools;
using System;


namespace DesignPatterns.Test
{
    public class TestChainOfResponsibilityPattern
    {
        public static void MakeDiscountTest()
        {
            Console.WriteLine("------------------------------------- CHAIN OF RESPONSABILITY PATTERN DISCOUNT EXAMPLE ---------------------------------");
            WriteTools.AddRow();

            DiscountCalculator discountCalculator = new DiscountCalculator();

            ShoppingCart shoppingCart = new ShoppingCart();

            Console.WriteLine($"Adding itens to {nameof(shoppingCart).ToUpperInvariant()}");
            shoppingCart.AddItem(new Item("Pen", 2000));
            Console.WriteLine($"Adding itens to {nameof(shoppingCart).ToUpperInvariant()}");
            shoppingCart.AddItem(new Item("Pencil", 30));
            WriteTools.AddRow();

            Console.WriteLine($"Calculing the discount total");
            double discount = discountCalculator.Calculate(shoppingCart);
            Console.WriteLine($"Discount total: ${discount}");
            WriteTools.AddRow();
            WriteTools.AddRow();

            Console.Read();
        }
    }
}
