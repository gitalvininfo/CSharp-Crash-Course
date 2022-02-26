using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if(age >= 18)
            {
                Console.WriteLine("You are registered.");
            }   else
            {
                Console.WriteLine("You are not registered.");
            }


            Console.Beep();
            Console.ReadKey();
            
        } 
    }
}