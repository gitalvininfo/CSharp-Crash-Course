using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            double x, y;

            Console.Write("Enter num 1: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter num 2: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Result is " + Multiply(x, y));

            Console.Beep();
            Console.ReadKey();

        } 

        static double Multiply(double x, double y)
        {
            return x * y;
        }
    }
}