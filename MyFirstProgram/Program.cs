using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 3; i++) 
            {
                singHappyBirthday("Alvin");
            }

            Console.Beep();
            Console.ReadKey();
            
        } 

        static void singHappyBirthday(String name)
        {
            Console.WriteLine("Happy Birthday to you... " + name);
            Console.WriteLine("Happy Birthday to you... " + name);
            Console.WriteLine("Happy Birthday to you... " + name);
            Console.WriteLine();
        }
    }
}