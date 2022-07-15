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
            _consoleUI.DisplayScreen(Header.TaxMenu, Options.MainMenu, Options.InputCall);
            int userOption = _consoleUI.InputUserOption(1, 2);

            switch (userOption)
            {
                case 1:
                    _incomeTaxFlow.NavigateIncomeTaxMenu();
                    break;
                case 2:
                    break;                
            }
            ScreenPresenter.ReturnMenu();
        }

        

    }
}
