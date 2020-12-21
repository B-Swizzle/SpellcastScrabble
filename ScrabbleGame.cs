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

        //Amount of players in a game (supports up to 4)
        private int Players;

        //Amount of points you get for playing all seven of your tiles in a turn
        public const int ALL_TILE_BONUS = 50;

        public ScrabbleGame()
        {
            Tiles = new TileSet();
            Players = 2;
        }

        //TODO: Tile set settings and custom dictionary for point values, multiple players


        protected class TileSet
        {
            //Contains the point value information for each letter
            private Dictionary<char, int> PointValues;

            //Default tile set constructor
            public TileSet()
            {
                PointValues = new Dictionary<char, int>();
                PointValues.Add('a', 1);
                PointValues.Add('b', 3);
                PointValues.Add('c', 3);
                PointValues.Add('d', 2);
                PointValues.Add('e', 1);
                PointValues.Add('f', 4);
                PointValues.Add('g', 2);
                PointValues.Add('h', 4);
                PointValues.Add('i', 1);
                PointValues.Add('j', 8);
                PointValues.Add('k', 5);
                PointValues.Add('l', 1);
                PointValues.Add('m', 3);
                PointValues.Add('n', 1);
                PointValues.Add('o', 1);
                PointValues.Add('p', 3);
                PointValues.Add('q', 10);
                PointValues.Add('r', 1);
                PointValues.Add('s', 1);
                PointValues.Add('t', 1);
                PointValues.Add('u', 1);
                PointValues.Add('v', 4);
                PointValues.Add('w', 4);
                PointValues.Add('x', 8);
                PointValues.Add('y', 4);
                PointValues.Add('z', 10);
                PointValues.Add('?', 0);
            }

            //Generates new point values for any given tile set
            public TileSet(Dictionary<char, int> pvs)
            {
                PointValues = pvs;
            }
        }
    }


}
