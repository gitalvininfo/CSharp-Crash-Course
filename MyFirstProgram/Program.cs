using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // thread = an execution path of a program
            // we can use multiple threads to perform
            // different tasks of our program at the same time
            // current thread running is main thread
            // using System.Threading;


            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";

            Thread thread1 = new Thread(() => CountDown("Player 1"));
            Thread thread2 = new Thread(() => CountUp("Player 2"));

            thread1.Start();
            thread2.Start();



            Console.WriteLine(mainThread.Name + " is complete!");
            Console.Beep();
            Console.ReadKey();
        }


        public static void CountDown(String name)
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Timer # 1: " + i + " secs" + " " + name);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #1 is finished");
        }

        public static void CountUp(String name)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Timer # 2: " + i + " secs" + " " + name);
                Thread.Sleep(1000);
            }

            Console.WriteLine("Timer #2 is finished");
        }


    }


}