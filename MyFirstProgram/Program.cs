using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            double temperature = 30;
            String message;

            message = temperature > 25 ? "Hot" : "Cold";

            Console.WriteLine(message);
            
            Console.Beep();
            Console.ReadKey();
        }

    }
}