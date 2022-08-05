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

        private bool existsEnemy(Position pos)
        {
            Piece p = table.Piece(pos);
            return p != null && p.color != color;
        }

        private bool free(Position pos)
        {
            return table.Piece(pos) == null;
        }

        public override bool[,] possibleMoves()
        {
            bool[,] mat = new bool[table.rows, table.columns];
            Position pos = new Position(0, 0);

            if(color == Color.Red)
            {
                pos.defineValues(position.row - 1, position.column);
                if(table.validPosition(pos) && free(pos))
                {
                    mat[pos.row, pos.column] = true;
                }

                pos.defineValues(position.row - 2, position.column);
                if (table.validPosition(pos) && free(pos) && qntMoves == 0)
                {
                    mat[pos.row, pos.column] = true;
                }

                pos.defineValues(position.row - 1, position.column - 1);
                if (table.validPosition(pos) && existsEnemy(pos))
                {
                    mat[pos.row, pos.column] = true;
                }

                pos.defineValues(position.row - 1, position.column + 1);
                if (table.validPosition(pos) && existsEnemy(pos))
                {
                    mat[pos.row, pos.column] = true;
                }
            }
            else
            {
                pos.defineValues(position.row + 1, position.column);
                if (table.validPosition(pos) && free(pos))
                {
                    mat[pos.row, pos.column] = true;
                }

                pos.defineValues(position.row + 2, position.column);
                if (table.validPosition(pos) && free(pos) && qntMoves == 0)
                {
                    mat[pos.row, pos.column] = true;
                }

                pos.defineValues(position.row + 1, position.column - 1);
                if (table.validPosition(pos) && existsEnemy(pos))
                {
                    mat[pos.row, pos.column] = true;
                }

                pos.defineValues(position.row + 1, position.column + 1);
                if (table.validPosition(pos) && existsEnemy(pos))
                {
                    mat[pos.row, pos.column] = true;
                }
            }
            return mat;
        }
    }
}
