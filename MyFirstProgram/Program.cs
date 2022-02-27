using System;
using System.Collections.Generic;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // generic = not specified to a particular data type
            // add <T> to: classes, methods, fields, etc
            // allows for code reusability for different data types

            int[] intArray = { 1, 2, 3 };
            double[] doubleArray = { 1.0, 2.0, 3.0 };
            String[] stringArrays = { "1", "2", "3" };

            DisplayElements(intArray);
            DisplayElements(doubleArray);
            DisplayElements(stringArrays);


            Console.Beep();
            Console.ReadKey();
        }

        public static void DisplayElements<T>(T[] array)
        {
            foreach(T item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }


    }


}