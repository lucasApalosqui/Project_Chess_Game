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

        private bool canMove(Position pos)
        {
            Piece p = table.Piece(pos);
            return p == null || p.color != this.color;
        }

        public override bool[,] possibleMoves()
        {
            bool[,] mat = new bool[table.rows, table.columns];
            Position pos = new Position(0, 0);

            // up
            pos.defineValues(position.row - 1, position.column);
            if(table.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
            }

            // northeast
            pos.defineValues(position.row - 1, position.column + 1);
            if (table.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
            }

            // right
            pos.defineValues(position.row, position.column + 1);
            if (table.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
            }

            // southeast
            pos.defineValues(position.row + 1, position.column + 1);
            if (table.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
            }

            // down
            pos.defineValues(position.row + 1, position.column);
            if (table.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
            }

            // southwest
            pos.defineValues(position.row + 1, position.column - 1);
            if (table.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
            }

            // left
            pos.defineValues(position.row, position.column - 1);
            if (table.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
            }

            // northwest
            pos.defineValues(position.row - 1, position.column - 1);
            if (table.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
            }

            return mat;
        }
    }
}
