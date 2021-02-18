using DesignPatterns.Entities;

namespace DesignPatterns.Taxations
{
    public class ICCC : ITaxation
    {
        public double Calculator(Account account)
        {
            if(account.Balance < 1000)
            {
                return account.Balance * 0.05;

            }
            else if(account.Balance < 3000)
            {
                return account.Balance * 0.07;
            }
            else if (account.Balance > 3000)
            {
                return (account.Balance * 0.08) + 30;
            }

            return 0;
        }
    }
}
