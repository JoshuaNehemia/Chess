using ChessLibs.Model.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
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
        private bool isMoved;
        #endregion

        #region CONSTRUCTOR
        //EMPTY
        public Piece()
        {
            this.Notation = ' ';
            this.Column = ' ';
            this.Row = -1;
            this.IsMoved = false;
        }
        //FILLED
        public Piece(bool color,char notation,char column,int row)
        {
            this.Color = color;
            this.Notation = notation;
            this.Column = column;
            this.Row = row;
            this.IsMoved = false;
        }
        #endregion

        #region PROPERTIES
        public bool Color { get => color; set => color = value; }
        public char Notation { get => notation; set => notation = value; }
        public char Column { get => column; set => column = value; }
        public int Row { get => row; set => row = value; }
        public bool IsMoved { get => isMoved; set => isMoved = value; }
        #endregion

        #region FUNCTION
        public void UpdatePosition(char column, int row)
        {
            this.Column = column;
            this.Row = row;
        }

        public List<Tile> GetPossibleMove(Tile[,] board)
        {

            return new List<Tile>();
        }

        public bool IsTileOccupiedByFriendlyPiece(Tile dest)
        {
            // Returns true if the destination tile has a piece of the same color.
            return dest.CurrentPiece.Color == this.Color;
        }

        public bool IsSuicide(Tile kings_tile,Tile dest, Tile[,] board)
        {
            King king = (King)kings_tile.CurrentPiece;
            return king.IsCheck(board);
        }

        #region TOOLS
        public int GetColumnIndex(char column)
        {
            return ((int)column - 65);
        }

        public int GetRowIndex(int row)
        {
            return row - 1;
        }

        public char SetColumnFromIndex(int index)
        {
            return (char)(index + 65);
        }

        public int SetRowFromIndex(int index)
        {
            return index + 1;
        }

        public bool IsOpponent(Piece pic)
        {
            return pic.Color != this.Color;
        }

        #endregion

        #endregion
    }
}
