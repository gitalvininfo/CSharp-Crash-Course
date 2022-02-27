using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            // interfaces = defines a contract that all classes inheriting from should follow
            // an interface declares "what a class should have"
            // an inheriting class defines "how it should do it"
            // benefit = security + multiple inheritance + plug and play


            Rabbit rabbit = new Rabbit();
            rabbit.Flee();

            Hawk hawk = new Hawk();
            hawk.Hunt();
            hawk.Flee();

            Fish fish = new Fish();
            fish.Flee();
            fish.Hunt();

            Console.Beep();
            Console.ReadKey();
        }

    }

    interface Prey
    {
        void Flee();
    }

    interface Predator
    {
        void Hunt();
    }


    class Rabbit : Prey
    {
        public void Flee()
        {
            Console.WriteLine("The rabbit runs away!");
        }
    }

    class Hawk : Predator, Prey
    {
        public void Hunt()
        {
            Console.WriteLine("The hawk is searching for food!");
        }
        public void Flee()
        {
            Console.WriteLine("The hawk flies away!");
        }

    }

    class Fish : Prey, Predator
    {

        public void Flee()
        {
            Console.WriteLine("The fish swims away!");
        }

        public void Hunt()
        {
            Console.WriteLine("The fish is searching for food!");
        }
    }

}