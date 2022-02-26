using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            int x, y, result;
            bool isContinue = true;

            while (isContinue)
            {
                try
                {
                    Console.Write("Enter num 1: ");
                    x = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter num 2: ");
                    y = Convert.ToInt32(Console.ReadLine());

                    result = x * y;

                    Console.WriteLine(result);
                    Console.WriteLine("Do you want to continue? (y/n)");

                    if(Console.ReadLine() == "y")
                    {
                        isContinue = true;
                    }
                        else
                    {
                        isContinue = false;
                    }

                }
                catch (FormatException e)
                {
                    Console.WriteLine("Enter only numbers pls.");
                    continue;
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("You cant divide by zero.");
                    continue;
                }

                finally
                {
                    Console.WriteLine("Thanks for try catch");
                }
            }
            Console.Beep();
            Console.ReadKey();
        }

    }
}