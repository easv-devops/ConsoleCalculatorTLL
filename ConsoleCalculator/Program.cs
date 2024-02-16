using System;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            double resultAddition = calculator.Add(5, 3);
            Console.WriteLine("Addition result: " + resultAddition);

            Console.ReadLine(); 
        }
    }
}
