using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter side a: ");
            double sideA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side b: ");
            double sideb = Convert.ToDouble(Console.ReadLine());

            double answer = Math.Sqrt((sideA * sideA) + (sideb * sideb));

            Console.WriteLine("Answer is " + answer);

            Console.Beep();
            Console.ReadKey();
            
        } 
    }
}