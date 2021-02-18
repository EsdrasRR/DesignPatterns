using DesignPatterns.Entities;
using DesignPatterns.Interfaces;

namespace DesignPatterns.Investments
{
    public class Conservative : IInvestment
    {
        public double Invest(Account account)
        {
            return account.Balance * 0.008;
        }
    }
}
