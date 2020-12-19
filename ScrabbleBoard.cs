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
        public ScrabbleBoard() : this(15)
        {
            //InsertDefaultTWS();
            //InsertDefaultDWS();
            //InsertDefaultTLS();
            //InsertDefaultDLS();
        }

        //Scrabble board constructor with defined side sizes
        public ScrabbleBoard(int size)
        {
            if (size % 3 != 0) throw new InvalidSettingsException("Scrabble board size must be divisible by 3 when using default modifier generation.");
            Board = new Cell[size-1, size-1];
        }

        /* TODO:
         * Resize game board with scrabble board sizes (size cap/scroll bar?)
         * Add default modifier generation
         */

        //Cells represent individual tiles on the board
        protected class Cell
        {
            public enum Modifier
            {
                WORD, //Tile provides a word multiplier
                LETTER, //Tile provides a letter multiplier
                NONE //Tile provides no bonusees
            }

            //Modifier bonus provided when a word is played on a tile
            public Modifier ModifierType { get; private set; }

            //Numerical score multiplier when modifier conditions are met. If the NONE modifier type is selected, this will always be 1
            public int ModifierAmount { get; private set; }

            //Default cell constructor
            public Cell() : this(Modifier.NONE, 1)
            {
            }

            //Create cells with modifiers to point values
            public Cell(Modifier modifier, int amt)
            {
                ModifierType = modifier;
                ModifierAmount = amt;
            }
        }
    }


}
