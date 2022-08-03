using System;
using ChessGame.board.Enum;
using ChessGame.board;

namespace ChessGame.Chess.PiecesChess
{
    internal class Tower : Piece
    {
        public Tower(Color color, Board table) : base(color, table)
        {

        }

        public override string ToString()
        {
            return "T";
        }
    }
}
