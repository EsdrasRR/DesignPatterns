using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Entities
{
    public class Item
    {
        public String Name { get; private set; }
        public Double Value { get; private set; }

        public Item(String name, Double value)
        {
            this.Name = name;
            this.Value = value;
        }

    }
}
