using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    internal class Game
    {
        public Player PlayerOne { get; private set; }
        public Player PlayerTwo { get; private set; }

        public Game()
        {
            PlayerOne = new Player();
            PlayerTwo = new Player();
        }

        public void PlayRound()
        {
            Move playerOnesMove = PlayerOne.ChooseMove();
            Move playerTwosMove = PlayerTwo.ChooseMove();
            string roundResult = DetermineWinner(playerOnesMove, playerTwosMove);
            Console.WriteLine(roundResult); 
        }

        public string DetermineWinner(Move p1, Move p2)
        {
            if (p1 == p2) return "Its a draw";

            return (p1, p2) switch
            {
                (Move.Rock, Move.Scissors) => $"{PlayerOne.Name} wins!",
                (Move.Paper, Move.Rock) => $"{PlayerOne.Name} wins!",
                (Move.Scissors, Move.Paper) => $"{PlayerOne.Name} wins!",
                _ => $"{PlayerTwo.Name} wins"
            };
        }
    }
}
