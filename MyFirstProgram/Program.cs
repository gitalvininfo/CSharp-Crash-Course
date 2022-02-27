using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            // polymorphism = greek word that means to have many forms
            // object can be identified by more than one type
            // ex. a Dog is also: Canine, Animal, Organism
            // if you need to create an array of different types of objects
            // you need to find what they have in common;

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            Vehicle[] vehicles = { car, bicycle, boat };

            foreach(Vehicle vehicle in vehicles)
            {
                vehicle.Go();
            }


            Console.Beep();
            Console.ReadKey();
        }

    }


    class Vehicle
    {
        public virtual void Go()
        {
            Console.WriteLine("The vehicle is moving");
        }
    }

    class Car : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The car is moving");
        }
    }

    class Bicycle : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The bicycle is moving");
        }
    }

    class Boat : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The boat is moving");
        }
    }


}