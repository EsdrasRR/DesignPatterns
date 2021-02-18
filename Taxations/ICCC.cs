namespace DesignPatterns.Taxations
{
    public class ICCC : ITaxation
    {
        public double Calculator(Budget budget)
        {
            if(budget.Value < 1000)
            {
                return budget.Value * 0.05;

            }
            else if(budget.Value < 3000)
            {
                return budget.Value * 0.07;
            }
            else if (budget.Value > 3000)
            {
                return (budget.Value * 0.08) + 30;
            }

            return 0;
        }
    }
}
