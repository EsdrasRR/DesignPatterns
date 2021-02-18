using DesignPatterns.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Entities
{
    public class ShoppingCart
    {
        public double Value { get; private set; }
        public IList<Item> Itens { get; private set; } = new List<Item>();

        public void AddItem(Item item)
        {
            Itens.Add(item);
            Value += item.Value;
        }
    }
}
