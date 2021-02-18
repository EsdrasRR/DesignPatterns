using DesignPatterns.Entities;
using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.Investments
{
    public class Moderate : IInvestment
    {
        private Random random;

        public Moderate()
        {
            this.random = new Random();
        }

        public double Invest(Account account)
        {
            if (random.Next(2) == 0)
            {
                return account.Balance * 0.025;
            }
            else
            {
                return account.Balance * 0.007;
            }
        }
    }
}
