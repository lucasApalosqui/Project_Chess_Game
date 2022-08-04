using System;
using ChessGame.board;
using ChessGame.board.Enum;
using ChessGame.Chess;


namespace ChessGame
{
    internal class Screen
    {
        public static void printMatch(ChessMatch match)
        {
            printBoard(match.board);
            Console.WriteLine();
            printCapturedPieces(match);
            Console.WriteLine();
            Console.WriteLine("Turn: " + match.turn);
            Console.WriteLine("Waiting movement for: " + match.actualPlayer);

        }

        public static void printCapturedPieces(ChessMatch match)
        {
            ConsoleColor aux = Console.ForegroundColor;
            Console.WriteLine("Captured Pieces: ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Red: ");
            printGroup(match.capturedPieces(Color.Red));

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Blue: ");
            printGroup(match.capturedPieces(Color.Blue));

            Console.ForegroundColor = aux;
        }

        public static void printGroup(HashSet<Piece> group)
        {
            Console.Write("[");
            foreach(Piece x in group)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine("]");
        }

        public static void printBoard(Board board)
        {
            for (int r = 0; r < board.rows; r++)
            {
                Console.Write(8 - r + " ");
                for (int c = 0; c < board.columns; c++)
                {

                    printsPiece(board.Piece(r, c));


                }
                Console.WriteLine();

            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void printBoard(Board board, bool[,] possiblePosition)
        {
            ConsoleColor original = Console.BackgroundColor;
            ConsoleColor alterBack = ConsoleColor.DarkGray;
            for (int r = 0; r < board.rows; r++)
            {
                Console.Write(8 - r + " ");
                for (int c = 0; c < board.columns; c++)
                {
                    if (possiblePosition[r, c])
                    {
                        Console.BackgroundColor = alterBack;
                    }
                    else
                    {
                        Console.BackgroundColor = original;
                    }
                    printsPiece(board.Piece(r, c));


                }
                Console.WriteLine();

            }
            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = original;
        }

        public static PositionChess readChessPosition()
        {
            string s = Console.ReadLine();
            int row = int.Parse(s[1] + "");
            char column = s[0];
            return new PositionChess(column, row);

        }

        public static void printsPiece(Piece piece)
        {

            if (piece == null)
            {
                Console.Write("- ");
            }
            else
            {



                if (piece.color == Color.White)
                {
                    Console.Write(piece);
                }

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
                Console.Write(" ");
            }
        }
    }
}
