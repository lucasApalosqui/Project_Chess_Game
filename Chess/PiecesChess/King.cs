using System;
using ChessGame.board;
using ChessGame.board.Enum;

namespace ChessGame.Chess.PiecesChess
{
    internal class King : Piece
    {
        public King(Color color, Board table) : base(color, table)
        {

        }

        public override string ToString()
        {
            return "K";
        }
    }
}
