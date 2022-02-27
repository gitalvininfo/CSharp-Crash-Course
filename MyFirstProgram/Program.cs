using System;
using System.Collections.Generic;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Player> players = new List<Player>();

            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");
            Player player3 = new Player("Player 3");

            players.Add(player1);
            players.Add(player2);
            players.Add(player3);

            foreach(Player player in players)
            {
                Console.WriteLine(player);
            }

            Console.Beep();
            Console.ReadKey();
        }

    }

    class Player
    {
        public String username;

        public Player(String username)
        {
            this.username = username;
        }

        public override string ToString()
        {
            return username;
        }
    }

}