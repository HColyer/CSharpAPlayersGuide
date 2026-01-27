using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace TicTacToe
{
    enum Symbol { X, O }
    internal class Player(Symbol symbol)
    {
        public Symbol Symbol { get; set; } = symbol;

        public byte Move()
        {
            Console.WriteLine($"{Symbol}'s turn!"); 
            
            byte playersMove;

            while (!byte.TryParse(Console.ReadLine(), out playersMove))
            {
                Console.WriteLine("Please enter a valid number:");
            }

            if (playersMove <= 0 || playersMove > 9)
            {
                Console.WriteLine("Please enter a valid number");
                playersMove = Convert.ToByte(Console.ReadLine());
            }
            return playersMove;
        }
    }
}
