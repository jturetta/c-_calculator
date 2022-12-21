using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            static void Soma()
            {}
            Console.Clear();

            Console.WriteLine("First number: ");
            float firstNumber = float.Parse(Console.ReadLine());

            Console.WriteLine("Second number: ");
            float secondNumber = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine($"The result is: {firstNumber + secondNumber}");
        }
        


    }
}
