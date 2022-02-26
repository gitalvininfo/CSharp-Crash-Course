using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;
            String answer;


            while(playAgain)
            {
                player = "";
                computer = "";
                answer = "";

                while(player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.Write("Enter ROCK, PAPER, SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }

                switch(random.Next(1, 4)) 
                {
                    case 1:
                        computer = "ROCK";
                        break;

                    case 2:
                        computer = "PAPER";
                        break;

                    case 3:
                        computer = "SCISSORS";
                        break;
                }

                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);

                switch(player)
                {
                    case "ROCK":
                        if(computer == "ROCK")
                        {
                            Console.WriteLine("It is a draw.");
                        }   else if (computer == "PAPER")
                        {
                            Console.WriteLine("You lose");
                        }   else
                        {
                            Console.WriteLine("You win");
                        }
                        break;

                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You win.");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("It is a draw.");
                        }
                        else
                        {
                            Console.WriteLine("You lose.");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You lose.");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You win");
                        }
                        else
                        {
                            Console.WriteLine("It is a draw.");
                        }
                        break;
                }



                while (answer != "y" && answer != "n")
                {
                    Console.WriteLine("Play again? (Y/N): ");
                    answer = Console.ReadLine();
                }

                if (answer == "y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }


            }


            Console.WriteLine("Thanks for playing...");
            Console.Beep();
            Console.ReadKey();
            
        } 
    }
}