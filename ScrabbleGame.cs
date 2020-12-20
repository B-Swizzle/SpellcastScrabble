using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

        //List of words in the Scrabble dictionary
        public List<String> Dictionary;

        public ScrabbleGame()
        {
            Tiles = new TileSet();
            Players = 2;
            LoadDictionary("dictionary.txt");
        }

        private void LoadDictionary(string path)
        {
            path = Path.GetFullPath(path).Replace("\\bin\\Debug", "");
            StreamReader fs = new StreamReader(path);
            Dictionary = new List<String>();
            try
            {
                string word;
                while ((word = fs.ReadLine()) != null)  
                    Dictionary.Add(word);
            }
            catch (Exception e)
            {
                throw new InvalidSettingsException("Failure while parsing dictionary, caused by " + e.GetType().ToString() + ":"
                    + e.StackTrace);
            }
            finally
            {
                fs.Dispose();
            }
        }

        /* TODO: Tile set settings
         * Multiple players
         * Custom dictionary
         * Word finder: 1. Find anagrams 2. Put all possible anagrams into list with point totals. Save highest point score 3. remove impossible combinations 4. Find by highest point total
         */


        protected class TileSet
        {
            //Contains the point value information for each letter
            private Dictionary<char, int> PointValues;

            //Contains the amount of tiles included in each tile set
            private Dictionary<char, int> TileCounts;

            //Default tile set constructor
            public TileSet()
            {
                AddDefaultPointValues();
                AddDefaultTileCounts();
            }

            private void AddDefaultTileCounts()
            {
                TileCounts = new Dictionary<char, int>();
                TileCounts.Add('a', 9);
                TileCounts.Add('b', 2);
                TileCounts.Add('c', 2);
                TileCounts.Add('d', 4);
                TileCounts.Add('e', 12);
                TileCounts.Add('f', 2);
                TileCounts.Add('g', 3);
                TileCounts.Add('h', 2);
                TileCounts.Add('i', 9);
                TileCounts.Add('j', 1);
                TileCounts.Add('k', 1);
                TileCounts.Add('l', 4);
                TileCounts.Add('m', 2);
                TileCounts.Add('n', 6);
                TileCounts.Add('o', 8);
                TileCounts.Add('p', 2);
                TileCounts.Add('q', 1);
                TileCounts.Add('r', 6);
                TileCounts.Add('s', 4);
                TileCounts.Add('t', 6);
                TileCounts.Add('u', 4);
                TileCounts.Add('v', 2);
                TileCounts.Add('w', 2);
                TileCounts.Add('x', 1);
                TileCounts.Add('y', 2);
                TileCounts.Add('z', 1);
                TileCounts.Add('?', 0);
            }

            private void AddDefaultPointValues()
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
