using System;
using ChessGame.board.Enum;

namespace ChessGame.board
{
    internal abstract class Piece
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

        public bool possibleMovesExistis()
        {
            bool[,] mat = possibleMoves();
            for(int r = 0; r < table.rows; r++)
            {
                for(int c = 0; c < table.columns; c++)
                {
                    if (mat[r,c])
                    {
                        return true;
                    }

                }
            }
            return false;
        }

        public bool canMoveTo(Position pos)
        {
            return possibleMoves()[pos.row, pos.column];
        }

        public abstract bool[,] possibleMoves();
    }
}
