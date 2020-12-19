using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrabbleMaker
{
    class ScrabbleGame
    {
        //Contains information about each tile
        private TileSet Tiles;

        public ScrabbleGame()
        {

        }

        protected class TileSet
        {
            //Contains the point value information for each letter
            private Dictionary<char, int> PointValues;

            //Default tile set constructor
            public TileSet()
            {

            }
        }
    }


}
