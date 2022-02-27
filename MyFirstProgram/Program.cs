using System;
using System.Collections.Generic;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // enums = special class that contains a set of named integer constants;
            // use enums when you have values that you know will not change;
            // to get the integer value from an item, you must explicitly convert to an int

            //Console.WriteLine(Planets.Pluto + " is planet # " + (int) Planets.Pluto );

            String name = PlanetRadius.Earth.ToString();
            int radius = (int)PlanetRadius.Earth;
            double volume = Volume(PlanetRadius.Earth);

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Radius: " + radius);
            Console.WriteLine("Volume: " + volume);


            Console.Beep();
            Console.ReadKey();
        }


        public static double Volume(PlanetRadius radius)
        {

            double volume = (4.0/3.0) * Math.PI * Math.Pow((int)radius, 3);
            return volume;
        }

    }

    enum Planets
    {
        Mercury,
        Venus,
        Earth,
        Mars,
        Jupiter,
        Saturn,
        Uranus,
        Neptune,
        Pluto
    }

    enum PlanetRadius
    {
        Mercury = 2439,
        Venus = 6051,
        Earth = 6371,
        Mars = 3389,
        Jupiter = 69911,
        Saturn = 58232,
        Uranus = 25362,
        Neptune = 24622,
        Pluto = 1188
    }


}