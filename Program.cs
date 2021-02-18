using DesignPatterns.Test;

namespace DesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region STRATEGY PATTERN

            //TestStrategyPattern.MakeTaxationTest();
            //TestStrategyPattern.MakeInvestmentsTest();

            #endregion

            #region CHAIN OF RESPONSABILITY PATTERN

            TestChainOfResponsibilityPattern.MakeDiscountTest();

            #endregion

        }
    }
}
