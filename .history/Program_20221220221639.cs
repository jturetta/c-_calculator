using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Subtraction();
        }

        static void Menu()
            {
                ConsoleriteLine("Choose an option: ");
            }

        static void Addition()
        {
            Console.Clear();

            Console.WriteLine("First number: ");
            float firstNumber = float.Parse(Console.ReadLine());

            Console.WriteLine("Second number: ");
            float secondNumber = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine($"The result is: {firstNumber + secondNumber}");

            Console.ReadKey();
        }

        static void Subtraction()
        {
            Console.Clear();

            Console.WriteLine("First number: ");
            float firstNumber = float.Parse(Console.ReadLine());

            Console.WriteLine("Second number: ");
            float secondNumber = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine($"The result is: {firstNumber - secondNumber}");

            Console.ReadKey();
        }

        static void Division()
        {
            Console.Clear();

            Console.WriteLine("First number: ");
            float firstNumber = float.Parse(Console.ReadLine());

            Console.WriteLine("Second number: ");
            float secondNumber = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine($"The result is: {firstNumber / secondNumber}");

            Console.ReadKey();
        }

        static void Multiplication()
        {
            Console.Clear();

            Console.WriteLine("First number: ");
            float firstNumber = float.Parse(Console.ReadLine());

            Console.WriteLine("Second number: ");
            float secondNumber = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine($"The result is: {firstNumber * secondNumber}");

            Console.ReadKey();
        }

    }
}

