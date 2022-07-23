using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player(0);
            Player player2 = new Player(0);

            //string p1 = player1.GetMove();
            //string p2 = player2.GetMove();

            //string statement = "Player 1 played " + p1 + " and player 2 played " + p2 + ".";
            List<string> whoWon = new List<string>();
            whoWon.Add("Both players win.");
            whoWon.Add("Player 1 wins.");
            whoWon.Add("Player 2 wins.");

            for(int i = 0; i < 10; i++)
            {
                string p1 = player1.GetMove();
                string p2 = player2.GetMove();

                string statement = "Player 1 played " + p1 + " and player 2 played " + p2 + ".";

                if (p1 == p2)
                {
                    player1.numberOfRoundsWon++;
                    player2.numberOfRoundsWon++;
                    Console.WriteLine(statement + whoWon[0]);
                }
                if (p1 == "Rock" && p2 == "Scissors" || p1 == "Paper" && p2 == "Rock" || p1 == "Scissors" && p2 == "Paper")
                {
                    player1.numberOfRoundsWon++;
                    Console.WriteLine(statement + whoWon[1]);
                }
                else
                {
                    player2.numberOfRoundsWon++;
                    Console.WriteLine(statement + whoWon[2]);
                }
            }

            Console.WriteLine("After 10 rounds, player 1 won " + player1.numberOfRoundsWon + " times, and player 2 won " + player2.numberOfRoundsWon + " times.");

        }

        public class Player
        {
            public int numberOfRoundsWon { get; set; }

            public Player(int n)
            {
                numberOfRoundsWon = n;
            }

            public string GetMove()
            {
                Random rnd = new Random();

                int num = rnd.Next(1,4);
                string move = String.Empty;

                if(num == 1)
                {
                    move = "Rock";
                }
                if (num == 2)
                {
                    move = "Paper";
                }
                if(num == 3)
                {
                    move = "Scissors";
                }

                return move;
            }
        }
    }
}
