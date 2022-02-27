using System;
using System.Collections.Generic;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // List = data structure that represents a list of objects that can be accessed by index.
            // similar to array, but can dynamically increase/decrease in size
            // using System.Collections.Generic;
            // but they waste more memory;s

            List<String> food = new List<String>();

            food.Add("fries");
            food.Add("pizza");
            food.Add("hamburger");
            food.Add("hotdog");
            food.Add("fries");

            //food.Remove("fries");
            //food.Insert(0, "sushi");
            //Console.WriteLine(food.Count);
            //Console.WriteLine(food.IndexOf("pizza"));
            //Console.WriteLine(food.LastIndexOf("fries"));
            //Console.WriteLine(food.Contains("pizza"));
            //food.Sort();
            //food.Reverse();
            //food.Clear();

            String[] foodArray = food.ToArray();


            foreach (String item in food)
            {
                Console.WriteLine(item);
            }

            Console.Beep();
            Console.ReadKey();
        }

    }

}