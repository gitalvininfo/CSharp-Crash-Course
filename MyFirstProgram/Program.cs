using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            String[] ford = { "Mustang", "F-150", "Explorer" };
            String[] chevy = { "Corvette", "Camaro", "Silverado" };
            String[] toyota = { "Corrola", "Camry", "Rav4" };

            String[,] parkingLot = {
                {"Mustang", "F-150", "Explorer" },
                { "Corvette", "Camaro", "Silverado" },
                { "Corrola", "Camry", "Rav4" }
            };

            //parkingLot[0, 2] = "Fusion";

            for(int i = 0; i < parkingLot.GetLength(0); i++)
            {
                for(int j = 0; j < parkingLot.GetLength(1); j++ )
                {
                    Console.Write(parkingLot[i, j] + " ");
                }
                Console.WriteLine("");
            }

            //foreach(String car in parkingLot)
            //{
            //    Console.WriteLine(car);
            //}

            Console.Beep();
            Console.ReadKey();
        }

    }
}