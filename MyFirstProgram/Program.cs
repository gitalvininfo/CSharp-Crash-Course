using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            // abstract classes = modifier that indicates missing components or incomplete implementation. Prevent instantiating.

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();
            //Vehicle vehicle = new Vehicle();


            Console.Beep();
            Console.ReadKey();
        }

    }
    
    abstract class Vehicle
    {
        public int speed = 0;

        public void Go()
        {
            Console.WriteLine("This vehicle is moving.");
        }
    }

    class Car : Vehicle 
    {
        public int wheels = 4;
    }

    class Bicycle : Vehicle
    {
        public int wheels = 2; 
    }

    class Boat : Vehicle
    {
        public int wheels = 0;
    }
}