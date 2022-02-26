using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess, numberToGuess, guesses;
            String response;

            while(playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                numberToGuess = random.Next(min, max + 1);

                while(guess != numberToGuess)
                {
                    Console.Write("Guess a number between " + min + " - " + max + ": ");
                    
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);
                    if (guess > numberToGuess)
                    {
                        Console.WriteLine("Guess is too high. Try again");
                    } 
                    else if (guess < numberToGuess)
                    {
                        Console.WriteLine("Guess is too low. Try again");
                    }  
                    guesses++;
                }

                Console.WriteLine("Your guess is right. \n" +
                "The number to guess is " + numberToGuess + "\n" +
                "Total number of guesses is " + guesses);

                Console.Write("Do you want to play again (Y/N): ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if(response == "Y")
                {
                    playAgain = true;
                }   else
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Thanks for playing");

            Console.Beep();
            Console.ReadKey();
            
        } 
    }
}