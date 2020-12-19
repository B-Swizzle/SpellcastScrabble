using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrabbleMaker
{
    class ScrabbleBoard
    {
        private Cell[,] Board;
        
        //Default ScrabbleBoard constructor
        public ScrabbleBoard()
        {
            Board = new Cell[15, 15];
        }

        protected class Cell
        {
            public Cell()
            {

            }
        }
    }


}
