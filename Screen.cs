using System;
using ChessGame.board;


namespace ChessGame
{
    internal class Screen
    {
        public static void printBoard(Board board)
        {
            for(int r = 0; r < board.rows; r++)
            {
                for(int c = 0; c < board.columns; c++)
                {
                    if(board.Piece(r, c) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(board.Piece(r, c) + " ");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
