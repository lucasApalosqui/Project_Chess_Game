using System;
using ChessGame.board;
using ChessGame.board.Enum;
using ChessGame.Chess;

namespace ChessGame
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Board pos = new Board(8, 8);

                pos.putPiece(new Pawn(Color.Red, pos), new Position(0, 0));
                pos.putPiece(new King(Color.Red, pos), new Position(1, 0));
                pos.putPiece(new Queen(Color.Red, pos), new Position(7, 5));

                Screen.printBoard(pos);
            }catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();
           

           
        }
    }
}
