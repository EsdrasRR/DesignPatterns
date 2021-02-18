using DesignPatterns.Test;

namespace DesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region STRATEGY PATTERN

            TestStrategyPattern testStrategyPattern = new TestStrategyPattern();

            testStrategyPattern.MakeTaxationTest();
            testStrategyPattern.MakeInvestmentsTest();

            #endregion



        }
    }
}
