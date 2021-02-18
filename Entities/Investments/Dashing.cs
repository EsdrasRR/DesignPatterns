using DesignPatterns.Entities;
using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Investments
{
    public class Dashing : IInvestment
    {
        private Random random;

        public Dashing()
        {
            this.random = new Random();
        }

        public double Invest(Account account)
        {
            int kick = random.Next(10);
            if (kick >= 0 && kick <= 1) 
            {
                return account.Balance * 0.5;
            } 
            else if (kick >= 2 && kick <= 4)
            {
                return account.Balance * 0.3;
            }
            else
            {
                return account.Balance * 0.006;
            }
        }
    }
}
