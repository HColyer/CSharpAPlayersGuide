using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    enum CellValue { Empty, X, O }
    internal class Board
    {
        public CellValue[,] BoardTiles { get; set; }

        public Board()
        {
            BoardTiles = new CellValue[3, 3];
        }

        public void DisplayBoard()
        {
            Console.WriteLine($" {DisplayTile(BoardTiles[0, 0])} | {DisplayTile(BoardTiles[0, 1])} | {DisplayTile(BoardTiles[0, 2])} \n---+---+---\n {DisplayTile(BoardTiles[1, 0])} | {DisplayTile(BoardTiles[1, 1])} | {DisplayTile(BoardTiles[1, 2])} \n---+---+---\n {DisplayTile(BoardTiles[2, 0])} | {DisplayTile(BoardTiles[2, 1])} | {DisplayTile(BoardTiles[2, 2])}\n ");
        }

        public void DisplayBoardForInstuctions()
        {
            Console.WriteLine($" 1 | 2 | 3 \n---+---+---\n 4 | 5 | 6 \n---+---+---\n 7 | 8 | 9 \n ");
        }

        public string DisplayTile(CellValue cellValue)
        {
            string result = (cellValue) switch
            {
                CellValue.Empty => " ",
                CellValue.X => "X",
                CellValue.O => "O",
                _ => "N/A"
            };
            return result;
        }

        public bool IsBoardFull()
        {
            for (int i = 0; i < BoardTiles.GetLength(0); i++)
            {
                for (int j = 0; j < BoardTiles.GetLength(1); j++)
                {
                    if (BoardTiles[i, j] == CellValue.Empty)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool HasAWinner()
        {

            // Check rows
            for (int row = 0; row < 3; row++)
            {
                if (BoardTiles[row, 0] != CellValue.Empty &&
                    BoardTiles[row, 0] == BoardTiles[row, 1] &&
                    BoardTiles[row, 1] == BoardTiles[row, 2])
                {
                    return true;
                }
            }

            // Check columns
            for (int col = 0; col < 3; col++)
            {
                if (BoardTiles[0, col] != CellValue.Empty &&
                    BoardTiles[0, col] == BoardTiles[1, col] &&
                    BoardTiles[1, col] == BoardTiles[2, col])
                {
                    return true;
                }
            }

            // Diagonal top-left to bottom-right
            if (BoardTiles[0, 0] != CellValue.Empty &&
                BoardTiles[0, 0] == BoardTiles[1, 1] &&
                BoardTiles[1, 1] == BoardTiles[2, 2])
            {
                return true;
            }

            // Diagonal top-right to bottom-left
            if (BoardTiles[0, 2] != CellValue.Empty &&
                BoardTiles[0, 2] == BoardTiles[1, 1] &&
                BoardTiles[1, 1] == BoardTiles[2, 0])
            {
                return true;
            }

            return false;

        }


        //public void ChangeTile(byte playersMove, Symbol symbol)
        //{
        //    CellValue cellValue  = playersMove switch
        //    {
        //        1 => BoardTiles[0, 0],
        //        2 => BoardTiles[0, 1],
        //        3 => BoardTiles[0, 2],
        //        4 => BoardTiles[1, 0],
        //        5 => BoardTiles[1, 1],
        //        6 => BoardTiles[1, 2],
        //        7 => BoardTiles[2, 0],
        //        8 => BoardTiles[2, 1],
        //        9 => BoardTiles[2, 2],
        //        _ => throw new NotImplementedException()
        //    };
        //    if (IsTileEmpty(cellValue))
        //    {
        //        if(playersSymbol == Symbol.O)
        //        {
        //            cellValue = CellValue.O;
        //        } else
        //        {
        //            cellValue = CellValue.X;
        //        }
        //    }

        //}

        public void ChangeTile(byte playerMove, CellValue symbol)
        {
            switch (playerMove)
            {
                case 1:
                    BoardTiles[0, 0] = symbol;
                    break;
                case 2:
                    BoardTiles[0, 1] = symbol;
                    break;
                case 3:
                    BoardTiles[0, 2] = symbol;
                    break;
                case 4:
                    BoardTiles[1, 0] = symbol;
                    break;
                case 5:
                    BoardTiles[1, 1] = symbol;
                    break;
                case 6:
                    BoardTiles[1, 2] = symbol;
                    break;
                case 7:
                    BoardTiles[2, 0] = symbol;
                    break;
                case 8:
                    BoardTiles[2, 1] = symbol;
                    break;
                case 9:
                    BoardTiles[2, 2] = symbol;
                    break;
            }

        }

        public bool IsTileTaken(byte playersMove)
        {
            int currentIteration = 1;
            for (int i = 0; i < BoardTiles.GetLength(0); i++)
            {
                for (int j = 0; j < BoardTiles.GetLength(1); j++)
                {
                    if (BoardTiles[i, j] == CellValue.Empty && playersMove == currentIteration)
                    {
                        return false;
                    }
                    currentIteration++;
                }
            }
            return true;
        }

        public string ChangeTileValue(byte playersMove, CellValue cellValue)
        {
            for (int i = 0; i < BoardTiles.GetLength(0); i++)
            {

                for (int j = 0; j < BoardTiles.GetLength(1); j++)
                {

                }
            }
            return "";
        }

        //public void ChangeTile(byte playersMove, Symbol symbol)
        //{
        //    CellValue tileToChange = GetTileToChange(playersMove);
        //    if (IsTileEmpty(tileToChange))
        //    {
        //        tileToChange = (CellValue)symbol;
        //    } else
        //    {
        //        Console.WriteLine("Tile is not empty");
        //    }
        //}

    }
}
