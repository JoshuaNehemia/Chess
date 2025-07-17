using ChessLibs.Model.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLibs
{
    public class Board
    {
        #region FIELD
        private Tile[,] tiles;
        #endregion


        #region CONSTRUCTOR
        //Empty
        public Board()
        {
            tiles = new Tile[8, 8];
            for(int i = 0; i < 8; i++)
            {
                // i -> Rows
                // 0 is bottom
                for(int j = 0; j < 8; j++)
                {
                    // j -> Columns
                    // 0 is left
                    tiles[i,j] = new Tile(8-i, (char)(65+j));
                }
            }
            this.SetPiece();
        }
        #endregion

        #region PROPERTIES
        public Tile[,] Tiles { get => tiles; set => tiles = value; }
        #endregion

        #region FUNCTION
        public void SetPiece() { 

            // SET BLACK PIECES (ROWS 0 & 1)
            // ===================================
            // Set Major Pieces
            tiles[0, 0].CurrentPiece = new Rook(false, tiles[0, 0].Column, tiles[0, 0].Row);      // Rook ♜
            tiles[0, 1].CurrentPiece = new Knight(false, tiles[0, 1].Column, tiles[0, 1].Row);    // Knight ♞
            tiles[0, 2].CurrentPiece = new Bishop(false, tiles[0, 2].Column, tiles[0, 2].Row);    // Bishop ♝
            tiles[0, 3].CurrentPiece = new Queen(false, tiles[0, 3].Column, tiles[0, 3].Row);      // Queen ♛
            tiles[0, 4].CurrentPiece = new King(false, tiles[0, 4].Column, tiles[0, 4].Row);        // King ♚
            tiles[0, 5].CurrentPiece = new Bishop(false, tiles[0, 5].Column, tiles[0, 5].Row);    // Bishop ♝
            tiles[0, 6].CurrentPiece = new Knight(false, tiles[0, 6].Column, tiles[0, 6].Row);    // Knight ♞
            tiles[0, 7].CurrentPiece = new Rook(false, tiles[0, 7].Column, tiles[0, 7].Row);      // Rook ♜

            // Set Pawns using a loop
            for (int col = 0; col < 8; col++)
            {
                tiles[1, col].CurrentPiece = new Pawn(false, tiles[1, col].Column, tiles[1, col].Row); // Pawn ♟
            }

            // SET WHITE PIECES (ROWS 6 & 7)
            // ===================================
            // Set Pawns using a loop
            for (int col = 0; col < 8; col++)
            {
                tiles[6, col].CurrentPiece = new Pawn(true, tiles[6, col].Column, tiles[6, col].Row); // Pawn ♙
            }

            // Set Major Pieces
            tiles[7, 0].CurrentPiece = new Rook(true, tiles[7, 0].Column, tiles[7, 0].Row);      // Rook ♖
            tiles[7, 1].CurrentPiece = new Knight(true, tiles[7, 1].Column, tiles[7, 1].Row);    // Knight ♘
            tiles[7, 2].CurrentPiece = new Bishop(true, tiles[7, 2].Column, tiles[7, 2].Row);    // Bishop ♗
            tiles[7, 3].CurrentPiece = new Queen(true, tiles[7, 3].Column, tiles[7, 3].Row);      // Queen ♕
            tiles[7, 4].CurrentPiece = new King(true, tiles[7, 4].Column, tiles[7, 4].Row);        // King ♔
            tiles[7, 5].CurrentPiece = new Bishop(true, tiles[7, 5].Column, tiles[7, 5].Row);    // Bishop ♗
            tiles[7, 6].CurrentPiece = new Knight(true, tiles[7, 6].Column, tiles[7, 6].Row);    // Knight ♘
            tiles[7, 7].CurrentPiece = new Rook(true, tiles[7, 7].Column, tiles[7, 7].Row);      // Rook ♖
        }

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

        #endregion


    }
}
