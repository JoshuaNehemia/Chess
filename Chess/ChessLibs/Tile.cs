using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLibs
{
    public class Tile
    {
        #region FIELD
        private Piece currentPiece;
        private Char column;
        private int row;
        #endregion

        #region CONSTRUCTOR
        //EMPTY
        public Tile()
        {
            this.Column = 'i';
            this.Row = 0;
        }
        //OBJECT
        public Tile(Char column,int row)
        {
            this.Column = column;
            this.Row = row;
        }
        #endregion

        #region PROPERTIES
        public Piece CurrentPiece { get => currentPiece; set => currentPiece = value; }
        public Char Column { get => column; set => column = value; }
        public int Row { get => row; set => row = value; }
        #endregion

        #region FUNCTION
        public String getColor()
        {
            if((this.Row%2) ==((int)this.Column % 2))
            {
                return "black";
            }
            else return "white";
        }
        #endregion
    }
}
