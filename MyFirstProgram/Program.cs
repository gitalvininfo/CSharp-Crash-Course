using System;
using System.Collections.Generic;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car(10000000);

            car.Speed = 50000000;

            Console.WriteLine(car.Speed);
            
            Console.Beep();
            Console.ReadKey();
        }

    }

    class Car
    {
        private int speed;

        public Car (int speed)
        {
            this.speed = speed;
        }

        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                if(speed > 500)
                {
                    speed = 500;
                }   else
                {
                    speed = value;
                }
            }
        }
    }

}