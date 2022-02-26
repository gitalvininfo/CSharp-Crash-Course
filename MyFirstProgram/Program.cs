using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            String name = Console.ReadLine();

            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello " + name + ", your age is " + age);


            Console.Beep();
            Console.ReadKey();
            
        } 
    }
}