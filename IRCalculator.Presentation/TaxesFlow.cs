using IRCalculator.Presentation.Interfaces;
using IRCalculator.Presentation.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRCalculator.Presentation
{
    public class TaxesFlow : ITaxesFlow
    {
        private readonly IIncomeTaxFlow _incomeTaxFlow;
        private readonly IConsoleUI _consoleUI;

        public TaxesFlow(IIncomeTaxFlow incomeTaxFlow, IConsoleUI consoleUI)
        {
            _incomeTaxFlow = incomeTaxFlow;
            _consoleUI = consoleUI;
        }

        public void NavigateTaxesMenu()
        {
            _consoleUI.DisplayScreen(Header.TaxesMenu, Options.TaxesMenu);
            int userOption = _consoleUI.InputUserOption(1, 2, Options.InputCall);

            switch (userOption)
            {
                case 1:
                    _incomeTaxFlow.NavigateIncomeTaxMenu();
                    break;

                case 2:
                    _consoleUI.ReturnMenu();
                    break;                
            }
            
        }       

    }
}
