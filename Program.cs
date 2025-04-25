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
            // Console Menu
            Console.WriteLine("Select an option:");
            Console.WriteLine("\n1.Addition");
            Console.WriteLine("\n2.Subtraction");
            Console.WriteLine("\n3.Multiplication");
            Console.WriteLine("\n4.Division");
            Console.WriteLine("\n5.Exit");
            Console.Write("\nYour option: ");

            // User input choice
            string option = Console.ReadLine();

            // Variables
            int num1, num2;

            // Switch case for the formula
            switch (option) // Use the 'option' variable here
            {
                case "1":
                    Console.Write("Enter the first number: ");
                    if (!int.TryParse(Console.ReadLine(), out num1))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        return;
                    }
                    Console.Write("Enter the second number: ");
                    if (!int.TryParse(Console.ReadLine(), out num2))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        return;
                    }
                    Console.WriteLine($"Your result is: {num1} + {num2} = {num1 + num2}");
                    break;

                case "2":
                    Console.Write("Enter the first number: ");
                    if (!int.TryParse(Console.ReadLine(), out num1))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        return;
                    }
                    Console.Write("Enter the second number: ");
                    if (!int.TryParse(Console.ReadLine(), out num2))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        return;
                    }
                    Console.WriteLine($"Your result is: {num1} - {num2} = {num1 - num2}");
                    break;

                case "3":
                    Console.Write("Enter the first number: ");
                    if (!int.TryParse(Console.ReadLine(), out num1))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        return;
                    }
                    Console.Write("Enter the second number: ");
                    if (!int.TryParse(Console.ReadLine(), out num2))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        return;
                    }
                    Console.WriteLine($"Your result is: {num1} * {num2} = {num1 * num2}");
                    break;

                case "4":
                    Console.Write("Enter the first number: ");
                    if (!int.TryParse(Console.ReadLine(), out num1))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        return;
                    }
                    Console.Write("Enter the second number: ");
                    if (!int.TryParse(Console.ReadLine(), out num2))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        return;
                    }
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Cannot divide by zero.");
                    }
                    else
                    {
                        Console.WriteLine($"Your result is: {num1} / {num2} = {(double)num1 / num2}");
                    }
                    break;

                case "5":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid option! Select from the menu");
                    break;
            }
        }
    }
}