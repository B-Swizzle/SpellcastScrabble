using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ScrabbleMaker
{
    class ScrabbleBoard
    {
        //2-d Cell array that keeps track of the board tiles
        public readonly Cell[,] Board;

        //Private int containing the bounds of the Board variable
        private int Max;

        
        //Default ScrabbleBoard constructor
        public ScrabbleBoard() : this(15)
        {
            InsertDefaultTWS();
            InsertDefaultDWS();
            InsertDefaultTLS();
            InsertDefaultDLS();
        }

        //Scrabble board constructor with defined side sizes
        //MUST be used by ALL constructors to define the game size and board colors. Each constructor should implement bonus point tiles in their own methods
        private ScrabbleBoard(int size)
        {
            //if (size % 3 != 0 || size % 2 != 1) throw new InvalidSettingsException("Scrabble board size must be divisible by 3 and odd when using default modifier generation.");
            //else if (size < 15) throw new InvalidSettingsException("The board is too small! Minimum size must be 15.");

            Max = size-1;
            Board = new Cell[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Board[i, j] = new Cell();
                }
            }

        }

        //Default modifier algorithm for double letter score tiles
        private void InsertDefaultDLS()
        {
            //Arrow DWS
            for (int i = 0; i < 2; i++)
            {
                if (Board[(Max / 2) + i, (Max / 2) + i].ModifierType == Cell.Modifier.NONE)
                    Board[(Max / 2) + i, (Max / 2) + i] = new Cell(Cell.Modifier.LETTER, 2);
                Board[(Max / 2) + i, (Max / 2) + i + 4] = new Cell(Cell.Modifier.LETTER, 2);
                Board[(Max / 2) + i + 4, (Max / 2) + i] = new Cell(Cell.Modifier.LETTER, 2);

                if (Board[(Max / 2) - i, (Max / 2) + i].ModifierType == Cell.Modifier.NONE)
                    Board[(Max / 2) - i, (Max / 2) + i] = new Cell(Cell.Modifier.LETTER, 2);
                Board[(Max / 2) - i, (Max / 2) + i + 4] = new Cell(Cell.Modifier.LETTER, 2);
                Board[(Max / 2) - i - 4, (Max / 2) + i] = new Cell(Cell.Modifier.LETTER, 2);

                if (Board[(Max / 2) - i, (Max / 2) - i].ModifierType == Cell.Modifier.NONE)
                    Board[(Max / 2) - i, (Max / 2) - i] = new Cell(Cell.Modifier.LETTER, 2);
                Board[(Max / 2) - i, (Max / 2) - i - 4] = new Cell(Cell.Modifier.LETTER, 2);
                Board[(Max / 2) - i - 4, (Max / 2) - i] = new Cell(Cell.Modifier.LETTER, 2);

                if (Board[(Max / 2) + i, (Max / 2) - i].ModifierType == Cell.Modifier.NONE)
                    Board[(Max / 2) + i, (Max / 2) - i] = new Cell(Cell.Modifier.LETTER, 2);
                Board[(Max / 2) + i, (Max / 2) - i - 4] = new Cell(Cell.Modifier.LETTER, 2);
                Board[(Max / 2) + i + 4, (Max / 2) - i] = new Cell(Cell.Modifier.LETTER, 2);
            }

            //Outside DWS
            Board[0, 3] = new Cell(Cell.Modifier.LETTER, 2);
            Board[0, Max-3] = new Cell(Cell.Modifier.LETTER, 2);
            Board[3, 0] = new Cell(Cell.Modifier.LETTER, 2);
            Board[3, Max] = new Cell(Cell.Modifier.LETTER, 2);
            Board[Max-3, Max] = new Cell(Cell.Modifier.LETTER, 2);
            Board[Max-3, 0] = new Cell(Cell.Modifier.LETTER, 2);
            Board[Max, 3] = new Cell(Cell.Modifier.LETTER, 2);
            Board[Max, Max-3] = new Cell(Cell.Modifier.LETTER, 2);

        }

        //Default modifier algorithm for triple letter score tiles
        private void InsertDefaultTLS()
        {
            for (int i = 1; i < Max; i += 4)
            {
                for (int j = 1; j < Max; j += 4)
                {
                    if (Board[i, j].ModifierType == Cell.Modifier.NONE)
                        Board[i, j] = new Cell(Cell.Modifier.LETTER, 3);
                }
            }
        }

        //Default modifier algorithm for double word score tiles
        private void InsertDefaultDWS()
        {

            Board[Max / 2, Max / 2] = new Cell(Cell.Modifier.WORD, 2);
            for (int i = 3; i < (Max/2); i++)
            {
                Board[(Max / 2) + i, (Max / 2) + i] = new Cell(Cell.Modifier.WORD, 2);
                Board[(Max / 2) - i, (Max / 2) + i] = new Cell(Cell.Modifier.WORD, 2);
                Board[(Max / 2) + i, (Max / 2) - i] = new Cell(Cell.Modifier.WORD, 2);
                Board[(Max / 2) - i, (Max / 2) - i] = new Cell(Cell.Modifier.WORD, 2);
            }
        }

        //Default modifier algorithm for triple word score tiles
        private void InsertDefaultTWS()
        {
            for (int i = 0; i < Max+1; i += Max / 2)
            {
                Board[i, 0] = new Cell(Cell.Modifier.WORD, 3);
                Board[i, Max / 2] = new Cell(Cell.Modifier.WORD, 3);
                Board[i, Max] = new Cell(Cell.Modifier.WORD, 3);
            }
        }

        /* TODO:
         * Resize game board with scrabble board sizes (size cap/scroll bar?)
         * In the view, add a GUI for custom settings generation and saving
         * Add Super Scrabble and Super Duper Scrabble algorithm
         */







        //Cells represent individual tiles on the board
        public class Cell
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

            //Color of the cell as it appears on the game board
            public Color CellColor;


            //Default cell constructor
            public Cell() : this(Modifier.NONE, 1)
            {
            }

            //Create cells with modifiers to point values
            public Cell(Modifier modifier, int amt)
            {
                ModifierType = modifier;
                ModifierAmount = amt;
                CellColor = DetermineCellColor(modifier, amt);
            }

            //Determine the cell color on construction
            private Color DetermineCellColor(Modifier mod, int amt)
            {
                switch(mod)
                {
                    case Modifier.LETTER:
                        return (amt == 2 ? Color.LightBlue : Color.Blue);
                    case Modifier.WORD:
                        return (amt == 2 ? Color.LightSalmon : Color.Red);
                    default: return Color.LightGray;
                }
            }
        }
    }


}
