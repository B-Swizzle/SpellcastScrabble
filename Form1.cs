using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrabbleMaker
{
    public partial class Form1 : Form
    {

        ScrabbleBoard GameBoard;
        ScrabbleGame Game;

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
            InitializeGameBoard();
            
        }
        private void CreditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SpellCast Scrabble Generator\nMade by Legend#4270",
                "Credits", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void PointValuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotImplemented();
        }

        private void DictionaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotImplemented();
        }

        private void GameBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotImplemented();
        }

        private void UsageInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotImplemented();
        }

        //initializes the scrabble board to contain all word and letter scores
        private void InitializeGameBoard()
        {
            GameBoard = new ScrabbleBoard();
        }

        //initializes the scrabble game dictionary
        private void InitializeGame()
        {
            Game = new ScrabbleGame();
        }

        //debug and not implemented method placeholder
        private void NotImplemented()
        {
            MessageBox.Show("This function is currently not implemented. If you believe this is a mistake, please contact Legend#4270.",
                "Not Implemented", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


    }
}
