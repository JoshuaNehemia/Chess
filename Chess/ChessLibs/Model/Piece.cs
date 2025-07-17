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
        private bool color;
        private char notation;
        private char column;
        private int row;
        private string sign;
        #endregion

        #region CONSTRUCTOR
        //EMPTY
        public Piece()
        {
            this.Notation = ' ';
            this.Column = ' ';
            this.Row = -1;
            this.Sign = " ";
        }
        //FILLED
        public Piece(bool color,char notation,char column,int row,string sign)
        {
            this.Color = color;
            this.Notation = notation;
            this.Column = column;
            this.Row = row;
            this.Sign = sign;
        }
        #endregion

        #region PROPERTIES
        public bool Color { get => color; set => color = value; }
        public char Notation { get => notation; set => notation = value; }
        public char Column { get => column; set => column = value; }
        public int Row { get => row; set => row = value; }
        public string Sign { get => sign; set => sign = value; }
        #endregion

        #region FUNCTION
        public void UpdatePosition(char column,int row)
        {
            this.Column = column;
            this.Row = row;
        }

        public List<string> GetPossibleMove(Board board)
        {

            return new List<string>();
        }
        #endregion
    }
}
