using DesignPatterns.Entities;

namespace DesignPatterns
{
    public class ICMS : ITaxation
    {
        public double Calculator(Account account)
        {
            return account.Balance * 0.06;
        }
    }
}
