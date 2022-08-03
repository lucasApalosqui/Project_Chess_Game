using System;
using ChessGame.board;
using ChessGame.board.Enum;


namespace ChessGame
{
    internal class Screen
    {
        public static void printBoard(Board board)
        {
            for(int r = 0; r < board.rows; r++)
            {
                Console.Write(8 - r + " ");
                for(int c = 0; c < board.columns; c++)
                {
                    if(board.Piece(r, c) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        printsPiece(board.Piece(r, c));
                        Console.Write(" ");
                    }
                    
                }
                Console.WriteLine();

            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void printsPiece(Piece piece)
        {
            if(piece.color == Color.White) { Console.Write(piece); }
            else if (piece.color == Color.Yellow)
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(piece);
                Console.ForegroundColor = aux;

            }
            else if (piece.color == Color.Blue)
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(piece);
                Console.ForegroundColor = aux;

            }
            else if (piece.color == Color.Red)
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(piece);
                Console.ForegroundColor = aux;

            }
            else if (piece.color == Color.Green)
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(piece);
                Console.ForegroundColor = aux;

            }
        }
    }
}
