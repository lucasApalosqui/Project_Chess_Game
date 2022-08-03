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
            while(table.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
                if(table.Piece(pos) != null && table.Piece(pos).color != this.color)
                {
                    break;
                }
                pos.row = pos.row - 1;
            }

            // down
            pos.defineValues(position.row + 1, position.column);
            while (table.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
                if (table.Piece(pos) != null && table.Piece(pos).color != this.color)
                {
                    break;
                }
                pos.row = pos.row + 1;
            }

            // right
            pos.defineValues(position.row, position.column + 1);
            while (table.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
                if (table.Piece(pos) != null && table.Piece(pos).color != this.color)
                {
                    break;
                }
                pos.row = pos.column + 1;
            }

            // lwft
            pos.defineValues(position.row, position.column - 1);
            while (table.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
                if (table.Piece(pos) != null && table.Piece(pos).color != this.color)
                {
                    break;
                }
                pos.row = pos.column - 1;
            }

            return mat;
        }
    }
}
