using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Entities
{
    public class Account
    {
        public double Balance { get; set; }

        public void Deposit(double value)
        {
            this.Balance += value;
        }

    }
}
