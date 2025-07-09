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
        }
        #endregion

        #region PROPERTIES
        public Tile[,] Tiles { get => tiles; set => tiles = value; }
        #endregion


    }
}
