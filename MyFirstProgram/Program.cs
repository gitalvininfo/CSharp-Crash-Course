using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            int friends = 5;

            //            friends = friends + 2;
            //            friends += 2;
            //            friends++;

            //            friends = friends - 2;
            //            friends -= 2;
            //            friends--;

            //            friends = friends * 2;
            //            friends *= 2;

            //            friends = friends / 2;
            //            friends /= 2;

            int remainder = friends % 3;


            Console.WriteLine(remainder);
            Console.Beep();
            Console.ReadKey();
            
        } 
    }
}