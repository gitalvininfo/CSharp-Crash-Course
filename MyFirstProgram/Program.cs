using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("===================");
                Console.WriteLine("Calculator Program");
                Console.WriteLine("===================");

                double num1, num2, result = 0;

                Console.Write("Enter number 1: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter number 2: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter number option: ");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Subtract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Divide");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine("Result is: " + result);

                        break;

                    case "-":
                        result = num1 - num2;
                        Console.WriteLine("Result is: " + result);

                        break;

                    case "*":
                        result = num1 * num2;
                        Console.WriteLine("Result is: " + result);

                        break;

                    case "/":
                        result = num1 / num2;
                        Console.WriteLine("Result is: " + result);

                        break;

                    default:
                        Console.WriteLine("Invalid option...");
                        break;
                }
                Console.WriteLine("Would you like to continue (Y/N): ");
            } 
            while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Bye");
            Console.Beep();
            Console.ReadKey();
            
        } 
    }
}