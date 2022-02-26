using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            String firstname = "Bro";
            String lastname = "Code";
            int age = 20;

            Console.WriteLine($"Hello { firstname, 10} { lastname}");


            Console.Beep();
            Console.ReadKey();
        }

    }
}