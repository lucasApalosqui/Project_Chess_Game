using System;
using ChessGame.board.Enum;
using ChessGame.board;


namespace ChessGame.Chess
{
    internal class Horse : Piece
    {
        public Horse(Color color, Board table) : base(color, table)
        {

        }

        public override string ToString()
        {
            return "H";
        }
    }
}
