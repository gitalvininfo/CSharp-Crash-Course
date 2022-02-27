using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            // ToString() = converts an object to its string representation so that is is nice to display.

            Car car = new Car("Chevy", "Corvette", "blue", 2022);

            Console.WriteLine(car);

            Console.Beep();
            Console.ReadKey();
        }

    }


    class Car
    {
        String make, model, color;
        int year;

        public Car(string make, string model, string color, int year)
        {
            this.make = make;
            this.model = model;
            this.color = color;
            this.year = year;
        }

        public override string ToString()
        {
            return "This is a " + make + " " + model;
        }
    }



}