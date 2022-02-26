using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = Checkout(3.99, 5.75, 15);

            Console.WriteLine(total);

            Console.Beep();
            Console.ReadKey();
        } 

        static double Checkout(params double[] prices)
        {
            double total = 0;

            foreach(double price in prices)
            {
                total = total + price;
            }

            return total;
        }
    }
}