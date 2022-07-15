using IRCalculator.Presentation.Interfaces;
using IRCalculator.Presentation.Messages;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRCalculator.Presentation
{
    public class MainFlow : IMainFlow
    {

        private readonly ITaxesFlow _taxesFlow;
        private readonly IConsoleUI _consoleUI;

        public MainFlow(ITaxesFlow taxesFlow, IConsoleUI consoleUI)
        {
            _taxesFlow = taxesFlow;
            _consoleUI = consoleUI;
        }

        public void BeginApp()
        {
            int userOption = -1;

            while (userOption != 2)
            {
                _consoleUI.DisplayScreen(Header.TaxesMenu, Options.TaxesMenu, Options.InputCall);
                userOption = _consoleUI.InputUserOption(1, 2);                

                switch (userOption)
                {
                    case 1:
                        _taxesFlow.NavigateTaxesMenu();
                        break;
                    case 2:
                        break;
                }
            }                     
            
        }
    }
}
