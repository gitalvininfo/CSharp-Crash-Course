using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            double total;

            total = Multiply(2, 3, 4);

            Console.WriteLine(total);

            Console.Beep();
            Console.ReadKey();
        } 

        static double Multiply(double x, double y)
        {
            return x * y;
        }

        static double Multiply(double x, double y, double z)
        {
            return x * y * z;
        }
    }
}