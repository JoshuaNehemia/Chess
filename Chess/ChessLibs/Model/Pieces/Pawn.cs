using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLibs.Model.Pieces
{
    public class Pawn : Piece
    {
        #region CONSTRUCTOR
        public Pawn(bool color,char column,int row) : base(color,'p',column,row, "♟")
        {

        }
        #endregion

        #region FUNCTION

        #endregion
    }
}
