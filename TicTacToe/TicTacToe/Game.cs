using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    internal class Game
    {
        public Board Board { get; set; }
        public Player PlayerOne { get; set; }
        public Player PlayerTwo { get; set; }

        public bool IsGamePlaying { get; private set; }

        public Game()
        {
            Board = new Board();
            PlayerOne = new Player(Symbol.X);
            PlayerTwo = new Player(Symbol.O);
            IsGamePlaying = true;

        }

        public void Play()
        {
            DisplayInstructions();
            Board.DisplayBoardForInstuctions();
            GameLoop();
            Console.WriteLine("Game Over");
        }

        public void GameLoop()
        {
            while (IsGamePlaying)
            {
                TakeTurn(PlayerOne, CellValue.X);
                if (Board.IsBoardFull() || Board.HasAWinner())
                {
                    if (Board.HasAWinner())
                    {
                        Console.WriteLine($"X Win!");
                    }
                    else
                    {
                        Console.WriteLine("Its Draw");
                    }
                    IsGamePlaying = false;
                    break;
                }

                TakeTurn(PlayerTwo, CellValue.O);
                if (Board.IsBoardFull() || Board.HasAWinner())
                {
                    if (Board.HasAWinner())
                    {
                        Console.WriteLine($"O Win!");
                    }
                    else
                    {
                        Console.WriteLine("Its Draw");
                    }
                    IsGamePlaying = false;
                    break;
                }
            }
        }

        public void TakeTurn(Player player, CellValue cellValue)
        {
            byte playerMove = player.Move();
            while (Board.IsTileTaken(playerMove))
            {
                Console.WriteLine("Tile is Taken");
                playerMove = player.Move();

            }
            Console.Clear();
            Board.ChangeTile(playerMove, cellValue);
            Board.DisplayBoard();
        }

        public void DisplayInstructions()
        {
            Console.WriteLine("Tic-Tac-Toe");
            Console.WriteLine($"Enter a number as displayed below to start the game\n");
        }
    }
}
