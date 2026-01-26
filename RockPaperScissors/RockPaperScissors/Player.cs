using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    
    internal class Player
    {
        public static int TotalNumberOfPlayers { get; set; }
        public string Name { get; private set; } = string.Empty;

        public Player()
        {
            TotalNumberOfPlayers++;
            Name = $"Player{TotalNumberOfPlayers}";
        }
        public Player(string name)
        {
            TotalNumberOfPlayers++;
            Name = name;
        }

        public Move ChooseMove()
        {
            Console.WriteLine($"{Name}, chose rock, rapper or scissors");
            string userInput = Console.ReadLine()!.ToLower();

            Move playersMove = userInput switch
            {
                "rock" => Move.Rock,
                "paper" => Move.Paper,
                "scissors" => Move.Scissors,
                _ => ChooseMove(),
            };
            Console.Clear();
            return playersMove;
        }
    }
}
