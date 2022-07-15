using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRCalculator.Presentation
{
    public interface IConsoleUI
    {

        public void DisplayScreen(string header, string options = "", string askSomething = "");

        public int InputUserOption(int fisrtOption, int lastOption);

        public double InputIncomeValue();

    }
}
