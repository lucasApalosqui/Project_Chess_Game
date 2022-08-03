using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.board
{
    internal class Board
    {
                                                  /* initial variables */
        /* var can get rows */
        public int rows { get; set; }

        /* var can get columns */
        public int columns { get; set; }

        /* var can get pieces and save yours respective positions */
        private Piece[,] piece;


                                                    /* Constructors */
        /* set the size of the board */
        public Board(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            piece = new Piece[rows, columns];
        }

                                                      /* Methods */

        /* checks if a piece is already in the indicated position */
        public bool existPiece(Position pos)
        {
            validatingPosition(pos);
            return Piece(pos) != null;
        }

        /* adds a position to a piece, receiving a row and column as a parameter */
        public Piece Piece(int row, int column)
        {
            return piece[row, column];
        }

        /* adds a position to a piece, receiving a position as a parameter */
        public Piece Piece(Position position)
        {
            return piece[position.row, position.column];
        }

        /* adds a specific piece to a position on the board */
        public void putPiece(Piece p, Position pos)
        {
            piece[pos.row, pos.column] = p;
            p.position = pos;
        }

        /* analyzes whether a position is valid or not */
        public bool validPosition(Position pos)
        {
            if (pos.row < 0 || pos.row >= rows || pos.column < 0 || pos.column >= columns)
            {
                return false;
            }
            return true;
        }

        /* validates if a position is valid and returns a message if not valid */
        public void validatingPosition(Position pos)
        {
            if (!validPosition(pos))
            {
                throw new BoardException("Invalid Position!");
            }
        }


    }
}
