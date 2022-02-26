using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number of columns: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter symbol: ");
            String symbol = Console.ReadLine();


            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    Console.Write(symbol);
                }
                Console.Write("\n");
            }


            Console.Beep();
            Console.ReadKey();
            
        } 
    }
}