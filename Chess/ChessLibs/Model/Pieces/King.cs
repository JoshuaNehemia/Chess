using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLibs.Model.Pieces
{
    public class King : Piece
    {

        #region CONSTRUCTOR
        public King(bool color, char column, int row) : base(color, 'K', column, row)
        {

        }
        #endregion

        #region FUNCTION
        public bool IsCheck(Tile[,] tiles)
        {
            if (CheckByKnight(tiles))
            {
                return true;
            }
            if (CheckByDiagonal(tiles))
            {
                return true;
            }
            if (CheckByStraight(tiles))
            {
                return true;
            }
            return CheckByPawn(tiles);
        }

        private bool CheckByKnight(Tile[,] tiles)
        {
            int currentCol = base.GetColumnIndex(this.Column);
            int currentRow = base.GetRowIndex(this.Row);

            int colCheck = currentCol + 2;
            int rowCheck = currentRow + 1;
            if ((tiles[colCheck, rowCheck].CurrentPiece.Notation == 'N') && (tiles[colCheck, rowCheck].CurrentPiece.Color != this.Color))
            {
                return true;
            }
            colCheck = currentCol + 2;
            rowCheck = currentRow - 1;
            if ((tiles[colCheck, rowCheck].CurrentPiece.Notation == 'N') && (tiles[colCheck, rowCheck].CurrentPiece.Color != this.Color))
            {
                return true;
            }
            colCheck = currentCol - 2;
            rowCheck = currentRow - 1;
            if ((tiles[colCheck, rowCheck].CurrentPiece.Notation == 'N') && (tiles[colCheck, rowCheck].CurrentPiece.Color != this.Color))
            {
                return true;
            }
            colCheck = currentCol - 2;
            rowCheck = currentRow + 1;
            if ((tiles[colCheck, rowCheck].CurrentPiece.Notation == 'N') && (tiles[colCheck, rowCheck].CurrentPiece.Color != this.Color))
            {
                return true;
            }
            colCheck = currentCol + 1;
            rowCheck = currentRow + 2;
            if ((tiles[colCheck, rowCheck].CurrentPiece.Notation == 'N') && (tiles[colCheck, rowCheck].CurrentPiece.Color != this.Color))
            {
                return true;
            }
            colCheck = currentCol - 1;
            rowCheck = currentRow + 2;
            if ((tiles[colCheck, rowCheck].CurrentPiece.Notation == 'N') && (tiles[colCheck, rowCheck].CurrentPiece.Color != this.Color))
            {
                return true;
            }
            colCheck = currentCol + 1;
            rowCheck = currentRow - 2;
            if ((tiles[colCheck, rowCheck].CurrentPiece.Notation == 'N') && (tiles[colCheck, rowCheck].CurrentPiece.Color != this.Color))
            {
                return true;
            }
            colCheck = currentCol - 1;
            rowCheck = currentRow - 2;
            if ((tiles[colCheck, rowCheck].CurrentPiece.Notation == 'N') && (tiles[colCheck, rowCheck].CurrentPiece.Color != this.Color))
            {
                return true;
            }
            return false;
        }


        private bool CheckByDiagonal(Tile[,] tiles)
        {
            int currentCol = base.GetColumnIndex(this.Column);
            int currentRow = base.GetRowIndex(this.Row);

            int colCheck = currentCol;
            int rowCheck = currentRow;
            Piece checkPiece = null;
            for (int i = 1; i < 8; i++)
            {
                colCheck = currentCol + i;
                rowCheck = currentRow + i;
                if (colCheck >= 0 && rowCheck >= 0 && colCheck < 8 && rowCheck < 8)
                {
                    checkPiece = tiles[rowCheck, colCheck].CurrentPiece;
                    if (checkPiece.Notation == 'B' || checkPiece.Notation == 'Q')
                    {
                        if (base.IsOpponent(checkPiece))
                        {
                            return true;
                        }
                    }
                }
                colCheck = currentCol + i;
                rowCheck = currentRow - i;
                if (colCheck >= 0 && rowCheck >= 0 && colCheck < 8 && rowCheck < 8)
                {
                    checkPiece = tiles[rowCheck, colCheck].CurrentPiece;
                    if (checkPiece.Notation == 'B' || checkPiece.Notation == 'Q')
                    {
                        if (base.IsOpponent(checkPiece))
                        {
                            return true;
                        }
                    }
                }
                colCheck = currentCol - i;
                rowCheck = currentRow + i;
                if (colCheck >= 0 && rowCheck >= 0 && colCheck < 8 && rowCheck < 8)
                {
                    checkPiece = tiles[rowCheck, colCheck].CurrentPiece;
                    if (checkPiece.Notation == 'B' || checkPiece.Notation == 'Q')
                    {
                        if (base.IsOpponent(checkPiece))
                        {
                            return true;
                        }
                    }
                }
                colCheck = currentCol - i;
                rowCheck = currentRow - i;
                if (colCheck >= 0 && rowCheck >= 0 && colCheck < 8 && rowCheck < 8)
                {
                    checkPiece = tiles[rowCheck, colCheck].CurrentPiece;
                    if (checkPiece.Notation == 'B' || checkPiece.Notation == 'Q')
                    {
                        if (base.IsOpponent(checkPiece))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
        private bool CheckByStraight(Tile[,] tiles)
        {
            int currentCol = base.GetColumnIndex(this.Column);
            int currentRow = base.GetRowIndex(this.Row);

            int colCheck = currentCol;
            int rowCheck = currentRow;
            Piece checkPiece = null;
            for (int i = 1; i < 8; i++)
            {
                colCheck = currentCol + i;
                rowCheck = currentRow;
                if (colCheck >= 0 && rowCheck >= 0 && colCheck < 8 && rowCheck < 8)
                {
                    checkPiece = tiles[rowCheck, colCheck].CurrentPiece;
                    if (checkPiece.Notation == 'R' || checkPiece.Notation == 'Q')
                    {
                        if (base.IsOpponent(checkPiece))
                        {
                            return true;
                        }
                    }
                }
                colCheck = currentCol - i;
                rowCheck = currentRow;
                if (colCheck >= 0 && rowCheck >= 0 && colCheck < 8 && rowCheck < 8)
                {
                    checkPiece = tiles[rowCheck, colCheck].CurrentPiece;
                    if (checkPiece.Notation == 'R' || checkPiece.Notation == 'Q')
                    {
                        if (base.IsOpponent(checkPiece))
                        {
                            return true;
                        }
                    }
                }
                colCheck = currentCol;
                rowCheck = currentRow + i;
                if (colCheck >= 0 && rowCheck >= 0 && colCheck < 8 && rowCheck < 8)
                {
                    checkPiece = tiles[rowCheck, colCheck].CurrentPiece;
                    if (checkPiece.Notation == 'R' || checkPiece.Notation == 'Q')
                    {
                        if (base.IsOpponent(checkPiece))
                        {
                            return true;
                        }
                    }
                }
                colCheck = currentCol;
                rowCheck = currentRow - i;
                if (colCheck >= 0 && rowCheck >= 0 && colCheck < 8 && rowCheck < 8)
                {
                    checkPiece = tiles[rowCheck, colCheck].CurrentPiece;
                    if (checkPiece.Notation == 'R' || checkPiece.Notation == 'Q')
                    {
                        if (base.IsOpponent(checkPiece))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        public bool CheckByPawn(Tile[,] tiles)
        {
            int currentCol = base.GetColumnIndex(this.Column);
            int currentRow = base.GetRowIndex(this.Row);

            int colCheck = currentCol + 1;
            int rowCheck = currentRow + 1;
            Piece checkPiece = null;
            if (this.Color)
            {
                rowCheck = currentRow - 1;
            }

            if (colCheck >= 0 && rowCheck >= 0 && colCheck < 8 && rowCheck < 8)
            {
                checkPiece = tiles[rowCheck, colCheck].CurrentPiece;
                if (checkPiece.Notation == 'p')
                {
                    if (base.IsOpponent(checkPiece))
                    {
                        return true;
                    }
                }
            }
            colCheck = currentCol - 1;
            if (colCheck >= 0 && rowCheck >= 0 && colCheck < 8 && rowCheck < 8)
            {
                checkPiece = tiles[rowCheck, colCheck].CurrentPiece;
                if (checkPiece.Notation == 'p')
                {
                    if (base.IsOpponent(checkPiece))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        #endregion
    }
}
