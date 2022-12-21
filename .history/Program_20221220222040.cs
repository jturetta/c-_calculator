using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
            {
                Console.WriteLine("Choose an option: ");
                Console.WriteLine("1 - Addition");
                Console.WriteLine("2 - Subtraction");
                Console.WriteLine("3 - Division");
                Console.WriteLine("4 - Multiplication");

                short option = short.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Addition();
                        break;
                    case 2:
                        Subtraction();
                        break;
                    case 3:
                        Division();
                        break;
                    case 4:
                        Multiplication();
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
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

