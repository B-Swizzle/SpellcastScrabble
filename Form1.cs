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

        private ScrabbleBoard GameBoard;
        private ScrabbleGame Game;
        private Label[,] VisualBoard;  //reminder if multiple game boards are added eventually to dispose of all labels in here

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
            InitializeGameBoard();
            
        }
        private void CreditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotImplemented();
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



        /*
         * Non-auto generated helper methods
         */

        //initializes the scrabble board to contain all word and letter scores
        private void InitializeGameBoard()
        {

            GameBoard = new ScrabbleBoard();
            VisualBoard = new Label[15, 15];
            int x = 130;
            int y = 70;

            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    Label l = new Label();
                    l.Location = new Point(x, y);
                    l.Size = new Size(20, 20);
                    l.AutoSize = false;
                    l.BackColor = GameBoard.Board[i, j].CellColor;
                    l.BorderStyle = BorderStyle.FixedSingle;

                    Controls.Add(l);
                    VisualBoard[i, j] = l;
                    x += 20;
                }
                y += 20;
                x = 130;
            }
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
