using System;
using ChessGame.board;

namespace ChessGame
{
    class Program
    {

        static void Main(string[] args)
        {
            Board pos = new Board(8, 8);

            Screen.printBoard(pos);

           
        }
    }
}
