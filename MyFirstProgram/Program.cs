using System;
using System.Collections.Generic;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Auto implemented property - shortcut when no additional logic is required in the property.
            // you do not have to define a property
            // you only have to write get; and/or set; inside the property

            Car car = new Car("Porche");
            car.Model = "Ferrari";

            Console.WriteLine(car.Model);

            Console.Beep();
            Console.ReadKey();
        }

    }

    class Car
    {
        public String Model { get; set; }

        public Car(String model)
        {
            this.Model = model;
        }
    }

}