using System;
using ChessGame.board.Enum;
using ChessGame.board;

namespace ChessGame.Chess.PiecesChess
{
    internal class Pawn : Piece
    {
        public Pawn(Color color, Board table) : base(color, table)
        {

        }

        public override string ToString()
        {
            return "P";
        }

        public override bool[,] possibleMoves()
        {
            throw new NotImplementedException();
        }
    }
}
