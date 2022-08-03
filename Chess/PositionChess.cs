using System;
using ChessGame.board;

namespace ChessGame.Chess
{
    internal class PositionChess
    {
        public char column { get; set; }
        public int row { get; set; }

        public PositionChess(char column, int row)
        {
            this.column = column;
            this.row = row;
        }

        public Position toPosition()
        {
            return new Position(8 - row, column - 'a');
        }

        public override string ToString()
        {
            return "" + column + row;
        }
    }
}
