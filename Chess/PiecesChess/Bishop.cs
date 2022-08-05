using System;
using ChessGame.board.Enum;
using ChessGame.board;

namespace ChessGame.Chess.PiecesChess
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

        private bool canMove(Position pos)
        {
            Piece p = table.Piece(pos);
            return p == null || p.color != color;
        }

        public override bool[,] possibleMoves()
        {
            bool[,] mat = new bool[table.rows, table.columns];
            Position pos = new Position(0, 0);

            // NO
            pos.defineValues(position.row - 1, position.column - 1);
            while(table.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
                if(table.Piece(pos) != null && table.Piece(pos).color != color)
                {
                    break;
                }
                pos.defineValues(pos.row - 1, pos.column - 1);
            }

            // NE
            pos.defineValues(position.row - 1, position.column + 1);
            while (table.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
                if (table.Piece(pos) != null && table.Piece(pos).color != color)
                {
                    break;
                }
                pos.defineValues(pos.row - 1, pos.column + 1);
            }

            // SE
            pos.defineValues(position.row + 1, position.column + 1);
            while (table.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
                if (table.Piece(pos) != null && table.Piece(pos).color != color)
                {
                    break;
                }
                pos.defineValues(pos.row + 1, pos.column + 1);
            }
            // SO
            pos.defineValues(position.row + 1, position.column - 1);
            while (table.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
                if (table.Piece(pos) != null && table.Piece(pos).color != color)
                {
                    break;
                }
                pos.defineValues(pos.row + 1, pos.column - 1);
            }
            return mat;

        }

       

    }
}
