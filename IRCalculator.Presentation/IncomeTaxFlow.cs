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
            var selectedMenu = ScreenPresenter.GetOption(
                ScreenPresenter.ComposeScreen(Header.IRMenu, Options.TaxMenu), 1, 3);
                        
            switch (selectedMenu)
            {
                case 1:
                    double income = _consoleUI.InputIncomeValue();
                    IncomeDTO newIncome = new(income);
                    Calcular(newIncome);
                    break;
                case 2:
                    _incomeTax.PrintTaxesTable();
                    break;
                case 3:
                    break;
            }

            ScreenPresenter.ReturnMenu();
        }

        private void Calcular(IncomeDTO income)
        {
            Console.WriteLine(_incomeTax.CalculateTax(income));
        }
    }
}
