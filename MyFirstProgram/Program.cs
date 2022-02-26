using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is the temperature outside: (C)");
            double temp = Convert.ToDouble(Console.ReadLine());
            
            if(temp >= 10 && temp <=25)
            {
                Console.WriteLine("It is warm upside.");
            }
            else if (temp <= -50 || temp >= 50)
            {
                Console.WriteLine("Do not go outside!");
            }

            Console.Beep();
            Console.ReadKey();
            
        } 
    }
}