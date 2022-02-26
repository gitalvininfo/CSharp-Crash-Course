using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            String[] cars = new string[5];

            cars[0] = "BMW";
            cars[1] = "Mustang";
            cars[2] = "Audi";
            cars[3] = "Lamborghini";
            cars[4] = "Ferrari";

            foreach(String car in cars)
            {
                Console.WriteLine(car);
            }


            Console.Beep();
            Console.ReadKey();
            
        } 
    }
}