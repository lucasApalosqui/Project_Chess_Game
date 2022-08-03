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

        public Piece(Color color, Board table)
        {
            this.position = null;
            this.color = color;
            this.qntMoves = 0;
            this.table = table;
        }

        public void incrementMovesQuantity()
        {
            qntMoves++;
        }
    }
}
