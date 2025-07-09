using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ChessLibs
{
    public class Piece
    {
        #region FIELD
        private String color;
        private int row;
        private int column;
        #endregion

        #region CONSTRUCTOR
        //EMPTY
        public Piece()
        {

        }
        //FILLED
        public Piece(String color, int row, int column)
        {
            this.Color = color;
            this.Row = row;
            this.Column = column;
        }
        #endregion

        #region PROPERTIES
        public string Color { get => color; set => color = value; }
        public int Row { get => row; set => row = value; }
        public int Column { get => column; set => column = value; }
        #endregion
    }
}
