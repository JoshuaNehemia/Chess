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
        private char column;
        private int row;
        private bool color;
        #endregion

        #region CONSTRUCTOR
        //EMPTY
        public Tile()
        {
            this.Column = 'i';
            this.Row = 0;
            this.CurrentPiece = new Piece();
        }
        //OBJECT
        public Tile(int row, char column)
        {
            this.Column = column;
            this.Row = row;
            this.CurrentPiece = new Piece();
            if (((this.Column - 65) % 2) == (this.Row % 2))
            {
                this.Color = false; //Black
            }
            else
            {
                this.Color = true; //White
            }
        }
        #endregion

        #region PROPERTIES
        public Piece CurrentPiece { get => currentPiece; set => currentPiece = value; }
        public char Column { get => column; set => column = value; }
        public int Row { get => row; set => row = value; }
        public bool Color { get => color; set => color = value; }
        #endregion

        #region FUNCTION

        #endregion
    }
}
