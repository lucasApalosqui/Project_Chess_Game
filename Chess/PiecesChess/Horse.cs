using System;
using ChessGame.board.Enum;
using ChessGame.board;


namespace ChessGame.Chess.PiecesChess
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

        private bool canMove(Position pos)
        {
            Piece p = table.Piece(pos);
            return p == null || p.color != color;
        }

        public override bool[,] possibleMoves()
        {
            bool[,] mat = new bool[table.rows, table.columns];
            Position pos = new Position(0, 0);

            pos.defineValues(position.row - 1, position.column - 2);
            if(table.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
            }

            pos.defineValues(position.row - 2, position.column - 1);
            if (table.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
            }

            pos.defineValues(position.row - 2, position.column + 1);
            if (table.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
            }

            pos.defineValues(position.row - 1, position.column + 2);
            if (table.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
            }

            pos.defineValues(position.row + 1, position.column + 2);
            if (table.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
            }

            pos.defineValues(position.row + 2, position.column + 1);
            if (table.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
            }

            pos.defineValues(position.row + 2, position.column - 1);
            if (table.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
            }

            pos.defineValues(position.row + 1, position.column - 2);
            if (table.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
            }

            return mat;

        }
    }
}
