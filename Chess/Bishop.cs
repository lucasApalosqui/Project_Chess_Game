using System;
using ChessGame.board.Enum;
using ChessGame.board;

namespace ChessGame.Chess
{
    internal class Bishop : Piece
    {
        public Bishop(Color color, Board table) : base(color, table)
        {

        }

        public override string ToString()
        {
            return "B";
        }
    }
}
