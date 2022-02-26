using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            //String[] cars = { "BMW", "Mustang", "Audi", "Lamborghini", "Ferrari" };

            String[] cars = new string[4];

            cars[0] = "BMW";
            cars[1] = "Mustang";
            cars[2] = "Audi";
            cars[3] = "Lamborghini";


            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine("\t" + cars[i]);
            }

            Console.Beep();
            Console.ReadKey();
            
        } 
    }
}