using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            Pizza pizza1 = new Pizza("stuffed crust", "red sauce", "mozzarella", "pepperoni");

            Pizza pizza2 = new Pizza("stuffed crust", "red sauce", "mozzarella");


            Console.Beep();
            Console.ReadKey();
        }

    }

    class Pizza
    {

        String bread, sauce, cheese, topping;

        public Pizza(string bread, string sauce, string cheese, string topping)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = topping;
        }

        public Pizza(string bread, string sauce, string cheese)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
        }
    }

    
}