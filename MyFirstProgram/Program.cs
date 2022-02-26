using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //for(int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            for(int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Happy New Year!!!");
            Console.Beep();
            Console.ReadKey();
            
        } 
    }
}