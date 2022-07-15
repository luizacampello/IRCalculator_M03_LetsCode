using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRCalculator.Presentation
{
    public static class ScreenPresenter
    {

        private static string Show(string screen, string errorMessage = "")
        {
            Console.Clear();
            Console.WriteLine(screen);

            if (!string.IsNullOrWhiteSpace(errorMessage))
            {
                PrintError(errorMessage);
            }

            string response = Console.ReadLine().Trim();
            return response;
        }

        public static int GetOption(string screen, int initialMenu, int endMenu, string customMessage = null)
        {
            int response;
            var messages = string.Empty;
            while (!int.TryParse(Show(screen, messages), out response) || !(response >= initialMenu && response <= endMenu))
            {
                messages = customMessage ?? "Opção Inválida";
            }

            return response;
        }

        public static string GetInput(string screen, Predicate<string> predicate, string customMessage = null)
        {
            string response;
            var messages = string.Empty;

            while (!predicate.Invoke(response = Show(screen, messages)))
            {
                messages = customMessage ?? "Opção Inválida";
            }
                

            return response;
        }

        public static string ComposeScreen(string header, string screen)
        {
            StringBuilder sb = new();

            sb.AppendLine(header);

            sb.AppendLine(screen);

            return sb.ToString();
        }

        public static void PrintError(string errorMessage)
        {
            Console.WriteLine();
            var defaultForegroundColor = Console.BackgroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(errorMessage);
            Console.ForegroundColor = defaultForegroundColor;
        }

        public static void ReturnMenu()
        {
            Console.WriteLine();
            Console.Write("Pressione qualquer tecla para retornar ao menu inicial");
            Console.ReadKey();
            return;
        }
    }
}
