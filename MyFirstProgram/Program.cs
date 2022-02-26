using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car("Ford", "Mustang", 2022, "red");
            Car car2 = new Car("Chevy", "Corvette", 2021, "blue");


            car1.Drive();
            car2.Drive();


            Console.Beep();
            Console.ReadKey();
        }

    }

    class Car
    {
        String make, model, color;
        int year;

        public Car(String make, String model, int year, String color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }

        public void Drive()
        {
            Console.WriteLine("You drive the " + make + " " + model);
        }
    }
}