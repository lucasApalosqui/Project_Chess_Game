using System;
using ChessGame.board.Enum;

namespace ChessGame.board
{
    internal class Piece
    {
        public Position position { get; set; }
        public Color color { get; set; }
        public int qntMoves { get; protected set; }
        public Board table { get; set; }


    }
}
