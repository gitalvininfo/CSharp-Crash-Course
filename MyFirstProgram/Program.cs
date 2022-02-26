using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = 123;

            int y = 321;

            int z = x + y;

            int age = 21;
            double height = 300.5;

            bool alive = true;

            char symbol = '@';

            String name = "Alvin";

            String username = symbol + name;

            Console.WriteLine("Your age is " + age);

            Console.WriteLine("Your height is " + height + "cm");

            Console.WriteLine("Are you alive? " + alive);

            Console.WriteLine("Your symbol is " + symbol);

            Console.WriteLine("Hello " + name);

            Console.WriteLine("Your username is " + username);

            Console.ReadKey();
        }
    }
}