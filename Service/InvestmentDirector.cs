using DesignPatterns.Entities;
using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Service
{
    public class InvestmentDirector
    {
        public void Invest(Account account, IInvestment investment)
        {
            double result = investment.Invest(account);
            var profit = result * 0.75;
            Console.WriteLine($"Profit: {profit}");
            account.Deposit(profit);
            Console.WriteLine($"New balance: {account.Balance}");
        }
    }
}
