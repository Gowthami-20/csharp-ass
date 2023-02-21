
using System;
namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegateCal d = new DelegateCal(); 
            d.Calculating += (a, b) =>
            {
                Console.WriteLine("Addition: {0}", a + b);
            };
            d.Calculating += (a, b) =>
            {
                Console.WriteLine("Subtraction: {0}", a - b);
            };
            d.Calculating += (a, b) =>
            {
                Console.WriteLine("Multiplication: {0}", a * b);
            };
            d.Calculating += (a, b) =>
            {
                Console.WriteLine("Division: {0}", a / b);
            };
            d.RaiseEvent(60, 20);
        }
    }
}