using DesignPatterns.Entities;
using DesignPatterns.Interfaces;
using DesignPatterns.Investments;
using DesignPatterns.Service;
using DesignPatterns.Tools;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Test
{
    public class TestStrategyPattern
    {
        public static void MakeTaxationTest()
        {
            Console.WriteLine("--------------------------------------------- STRATEGY PATTERN TAX EXAMPLE ---------------------------------------------");
            WriteTools.AddRow();

            Account account = new Account();
            account.Balance = 500;

            Console.WriteLine($"Creating {nameof(account)} and adding ${account.Balance} balance.");
            WriteTools.AddRow();

            ITaxation iss = new ISS();
            Console.WriteLine($"Creating {nameof(iss).ToUpperInvariant()} taxation");
            ITaxation icms = new ICMS();
            Console.WriteLine($"Creating {nameof(icms).ToUpperInvariant()} taxation");
            WriteTools.AddRow();

            TaxCalculator calculator = new TaxCalculator();

            Console.WriteLine($"Applying {nameof(icms).ToUpperInvariant()} fee.");
            calculator.PerformsCalculation(account, icms);
            WriteTools.AddRow();

            Console.WriteLine($"Applying {nameof(iss).ToUpperInvariant()} fee.");
            calculator.PerformsCalculation(account, iss);
            WriteTools.AddRow();
            WriteTools.AddRow();

            Console.Read();
        }

        public static void MakeInvestmentsTest()
        {
            Console.WriteLine("------------------------------------------ STRATEGY PATTERN INVESTMENT EXAMPLE -----------------------------------------");
            WriteTools.AddRow();

            Account account = new Account();
            account.Balance = 1000;
            Console.WriteLine($"Creating {nameof(account)} and adding ${account.Balance} balance.");
            WriteTools.AddRow();

            IInvestment conservative = new Conservative(); 
            Console.WriteLine($"Creating {nameof(conservative)} investment");
            IInvestment dashing = new Dashing();
            Console.WriteLine($"Creating {nameof(dashing)} investment");
            IInvestment moderate = new Moderate();
            Console.WriteLine($"Creating {nameof(moderate)} investment");
            WriteTools.AddRow();

            InvestmentDirector investmentDirector = new InvestmentDirector();

            Console.WriteLine($"Making {nameof(conservative)} investment");
            investmentDirector.Invest(account, conservative);
            WriteTools.AddRow();


            Console.WriteLine($"Making {nameof(dashing)} investment");
            investmentDirector.Invest(account, dashing);
            WriteTools.AddRow();

            Console.WriteLine($"Making {nameof(moderate)} investment");
            investmentDirector.Invest(account, moderate); WriteTools.AddRow();

            Console.ReadKey();

        }


    }
}
