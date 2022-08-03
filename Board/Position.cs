using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.board
{
    internal class Position
    {
        public int row;
        public int column;

        public Position(int row, int column)
        {
            this.row = row;
            this.column = column;
        }

        public void defineValues(int row, int column)
        {
            this.row = row;
            this.column = column;
        }

        public override string ToString()
        {
            return "Position: "
                + row 
                + " , "
                + column;
        }
    }
}
