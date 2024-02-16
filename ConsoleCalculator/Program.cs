using System;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            double resultAddition = Calculator.Add(5, 3);
            Console.WriteLine("Addition result: " + resultAddition);

            double resultSubtraction = Calculator.Subtract(10, 4);
            Console.WriteLine("Subtraction result: " + resultSubtraction);

            double resultMultiplication = Calculator.Multiply(7, 2);
            Console.WriteLine("Multiplication result: " + resultMultiplication);

            try
            {
                double resultDivision = Calculator.Divide(15, 3);
                Console.WriteLine("Division result: " + resultDivision);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.ReadLine(); // Hold konsolvinduet åbent
        }
    }
}
