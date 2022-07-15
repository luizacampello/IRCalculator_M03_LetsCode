using IRCalculator.Presentation.Interfaces;
using IRCalculator.Presentation.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRCalculator.Presentation
{
    public class ConsoleUI : IConsoleUI
    {
        private string ComposeScreen(string header, string options)
        {
            StringBuilder sb = new();

            sb.AppendLine(header);

            sb.AppendLine(options);

            sb.AppendLine(string.Empty);

            return sb.ToString();
        }

        public void DisplayScreen(string header, string options)
        {
            Console.Clear();
            Console.WriteLine(ComposeScreen(header, options));
        }

        public int InputUserOption(int fisrtOption, int lastOption, string inputMessage)
        {
            bool validInput = false;

            

            while (!validInput)
            {
                Console.Write(inputMessage);
                string userInput = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(userInput))
                {
                    PrintError(Errors.NullOrWhiteSpaceInput);
                    continue;
                }

                bool validFormat = int.TryParse(userInput, out int validFormatUserInput);

                if (validFormat)
                {
                    if (validFormatUserInput >= fisrtOption & validFormatUserInput <= lastOption)
                    {
                        return validFormatUserInput;
                    }

                    PrintError(Errors.InvalidOption);
                    continue;
                }

                PrintError(Errors.InvalidFormat);
            }

            throw new Exception();
        }

        public double InputIncomeValue(string inputMessage)
        {
            Console.Clear();
            bool validInput = false;            

            while (!validInput)
            {
                Console.Write(inputMessage);
                string userInput = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(userInput))
                {
                    PrintError(Errors.NullOrWhiteSpaceInput);
                    continue;
                }
                             

                bool validFormat = double.TryParse(userInput, out double validFormatUserInput);

                if (validFormat)
                {
                    return validFormatUserInput;
                }

                PrintError(Errors.InvalidFormat);
            }

            throw new Exception();
        }

        private static void PrintError(string errorMessage)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(errorMessage);
            Console.WriteLine();
            Console.ResetColor();
        }

        public void ReturnMenu()
        {
            Console.WriteLine();
            Console.Write("Pressione qualquer tecla para retornar ao menu inicial");
            Console.ReadKey();
            return;
        }
    }
}
