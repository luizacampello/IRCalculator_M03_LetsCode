using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRCalculator.Presentation.Interfaces
{
    public interface IConsoleUI
    {

        public void DisplayScreen(string header, string options);

        public int InputUserOption(int fisrtOption, int lastOption, string inputMessage);

        public double InputIncomeValue(string inputMessage);

        public void ReturnMenu();

    }
}
