using System.Text;
using System.Transactions;

namespace TechPrakt2024Task0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding =Encoding.UTF8;
            Console.Write("Enter the first number: ");
            if  (double.TryParse(Console.ReadLine(), out double number1))
            {
                Console.Write("Ente the second number: ");
               if(double.TryParse(Console.ReadLine(), out double number2))
               {
                    double add = number1 + number2;
                    Console.WriteLine($"Sum of numbers {number1} and {number2} = {add}");
               }
                else
                {
                    Console.WriteLine("Incorrect second number.");
                }
            }
            else
            {
                Console.WriteLine("Incorrect first number.");
            }
        }
    }
}
