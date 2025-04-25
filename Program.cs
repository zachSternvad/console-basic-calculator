using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_basic_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            Console.WriteLine("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Console Menu
            Console.WriteLine("Select an option:");
            Console.WriteLine("\n1.Addition");
            Console.WriteLine("\n2.Subtraction");
            Console.WriteLine("\n3.Multiplication");
            Console.WriteLine("\n4.Division");
            Console.WriteLine("\n5.Exit");
            Console.Write("Your option: ");

            // Formula
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine($"Your result is: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "2":
                    Console.WriteLine($"Your result is: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "3":
                    Console.WriteLine($"Your result is: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "4":
                    Console.WriteLine($"Your result is: {num1} / {num2} = " + (num1 / num2));
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
