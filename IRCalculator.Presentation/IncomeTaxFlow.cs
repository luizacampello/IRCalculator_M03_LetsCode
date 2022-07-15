using IRCalculator.Domain;
using IRCalculator.Presentation.Interfaces;
using IRCalculator.Presentation.Messages;
using IRCalculator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRCalculator.Presentation
{
    public class IncomeTaxFlow : IIncomeTaxFlow
    {
        private readonly IIncomeTaxCalculator _incomeTax;
        private readonly IConsoleUI _consoleUI;

        public IncomeTaxFlow(IIncomeTaxCalculator incomeTax, IConsoleUI consoleUI)
        {
            _incomeTax = incomeTax;
            _consoleUI = consoleUI;
        }

        public void NavigateIncomeTaxMenu()
        {
            _consoleUI.DisplayScreen(Header.IncomeTaxMenu, Options.IncomeTaxMenu);
            int userOption = _consoleUI.InputUserOption(1, 3, Options.InputCall);

            switch (userOption)
            {
                case 1:
                    IncomeDTO newIncome = CreateIncome();
                    CalculateIncomeTax(newIncome);
                    break;

                case 2:
                    _incomeTax.PrintAliquotTable();
                    break;

                case 3:
                    break;
            }

            _consoleUI.ReturnMenu();
        }

        private void CalculateIncomeTax(IncomeDTO newIncome)
        {
            Console.WriteLine();
            Console.WriteLine($" - Valor a ser pago {_incomeTax.CalculateTax(newIncome).ToString("C")}");
        }

        private IncomeDTO CreateIncome()
        {
            double income = _consoleUI.InputIncomeValue(Options.InputValueCall);
            return new(income);
        }

    }
}
