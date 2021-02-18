using DesignPatterns.Entities;

namespace DesignPatterns
{
    public class ISS : ITaxation
    {
        public double Calculator(Account account)
        {
            return account.Balance * 0.1;
        }
    }
}
