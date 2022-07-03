using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Podaj pierwszą liczbę: ");
                var num1 = GetInput();

                Console.WriteLine("Jaką operację chcesz wykonać?\nMożliwe operacje to: '+', '-', '/', '*'");
                var action = Console.ReadLine();

                Console.WriteLine("Podaj drugą liczbę: ");
                var num2 = GetInput();

                var result = Calculate(num1, num2, action);

                Console.WriteLine("Wynik twojego działania to: " + result);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }

        private static int GetInput()
        {
            if (!int.TryParse(Console.ReadLine(), out int input))
                throw new Exception("Podana wartość jest nieprawidłowa");

            return input;
        }
        private static int Calculate(int num1, int num2, string action)
        {
            switch (action)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "/":
                    return num1 / num2;
                case "*":
                    return num1 * num2;
                default:
                    throw new Exception("Wybrałeś złą operację!");
            }
        }
    }
}
