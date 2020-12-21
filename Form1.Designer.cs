namespace ScrabbleMaker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointValuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usageInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GameBorder = new System.Windows.Forms.Label();
            this.ResultDisplay = new System.Windows.Forms.Label();
            this.GenerateAnagramBtn = new System.Windows.Forms.Button();
            this.GenerateBestMoveBtn = new System.Windows.Forms.Button();
            this.TileGroupBox = new System.Windows.Forms.GroupBox();
            this.TileListLabel = new System.Windows.Forms.Label();
            this.TileInputButton = new System.Windows.Forms.Button();
            this.resetBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.TileGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pointValuesToolStripMenuItem,
            this.dictionaryToolStripMenuItem,
            this.gameBoardToolStripMenuItem,
            this.resetBoardToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // pointValuesToolStripMenuItem
            // 
            this.pointValuesToolStripMenuItem.Name = "pointValuesToolStripMenuItem";
            this.pointValuesToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.pointValuesToolStripMenuItem.Text = "Point Values";
            this.pointValuesToolStripMenuItem.Click += new System.EventHandler(this.PointValuesToolStripMenuItem_Click);
            // 
            // dictionaryToolStripMenuItem
            // 
            this.dictionaryToolStripMenuItem.Name = "dictionaryToolStripMenuItem";
            this.dictionaryToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.dictionaryToolStripMenuItem.Text = "Dictionary";
            this.dictionaryToolStripMenuItem.Click += new System.EventHandler(this.DictionaryToolStripMenuItem_Click);
            // 
            // gameBoardToolStripMenuItem
            // 
            this.gameBoardToolStripMenuItem.Name = "gameBoardToolStripMenuItem";
            this.gameBoardToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.gameBoardToolStripMenuItem.Text = "Game Board";
            this.gameBoardToolStripMenuItem.Click += new System.EventHandler(this.GameBoardToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usageInformationToolStripMenuItem,
            this.creditsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // usageInformationToolStripMenuItem
            // 
            this.usageInformationToolStripMenuItem.Name = "usageInformationToolStripMenuItem";
            this.usageInformationToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.usageInformationToolStripMenuItem.Text = "Usage Information";
            this.usageInformationToolStripMenuItem.Click += new System.EventHandler(this.UsageInformationToolStripMenuItem_Click);
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.creditsToolStripMenuItem.Text = "Credits";
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.CreditsToolStripMenuItem_Click);
            // 
            // GameBorder
            // 
            this.GameBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameBorder.Location = new System.Drawing.Point(130, 70);
            this.GameBorder.Name = "GameBorder";
            this.GameBorder.Size = new System.Drawing.Size(315, 315);
            this.GameBorder.TabIndex = 2;
            this.GameBorder.Text = "\r\n";
            // 
            // ResultDisplay
            // 
            this.ResultDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.ResultDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultDisplay.Location = new System.Drawing.Point(127, 499);
            this.ResultDisplay.Name = "ResultDisplay";
            this.ResultDisplay.Size = new System.Drawing.Size(318, 53);
            this.ResultDisplay.TabIndex = 3;
            this.ResultDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GenerateAnagramBtn
            // 
            this.GenerateAnagramBtn.Location = new System.Drawing.Point(130, 457);
            this.GenerateAnagramBtn.Name = "GenerateAnagramBtn";
            this.GenerateAnagramBtn.Size = new System.Drawing.Size(87, 39);
            this.GenerateAnagramBtn.TabIndex = 4;
            this.GenerateAnagramBtn.Text = "Generate Anagrams";
            this.GenerateAnagramBtn.UseVisualStyleBackColor = true;
            this.GenerateAnagramBtn.Click += new System.EventHandler(this.GenerateAnagramBtn_Click);
            // 
            // GenerateBestMoveBtn
            // 
            this.GenerateBestMoveBtn.Location = new System.Drawing.Point(358, 457);
            this.GenerateBestMoveBtn.Name = "GenerateBestMoveBtn";
            this.GenerateBestMoveBtn.Size = new System.Drawing.Size(86, 39);
            this.GenerateBestMoveBtn.TabIndex = 5;
            this.GenerateBestMoveBtn.Text = "Generate Best Move";
            this.GenerateBestMoveBtn.UseVisualStyleBackColor = true;
            this.GenerateBestMoveBtn.Click += new System.EventHandler(this.GenerateBestMoveBtn_Click);
            // 
            // TileGroupBox
            // 
            this.TileGroupBox.Controls.Add(this.TileListLabel);
            this.TileGroupBox.Location = new System.Drawing.Point(132, 387);
            this.TileGroupBox.Name = "TileGroupBox";
            this.TileGroupBox.Size = new System.Drawing.Size(312, 32);
            this.TileGroupBox.TabIndex = 6;
            this.TileGroupBox.TabStop = false;
            this.TileGroupBox.Text = "Your Tiles";
            // 
            // TileListLabel
            // 
            this.TileListLabel.AutoSize = true;
            this.TileListLabel.Location = new System.Drawing.Point(55, 12);
            this.TileListLabel.Name = "TileListLabel";
            this.TileListLabel.Size = new System.Drawing.Size(215, 13);
            this.TileListLabel.TabIndex = 0;
            this.TileListLabel.Text = "None! Add tiles using the \"Tile Input\" button";
            this.TileListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TileInputButton
            // 
            this.TileInputButton.Location = new System.Drawing.Point(223, 457);
            this.TileInputButton.Name = "TileInputButton";
            this.TileInputButton.Size = new System.Drawing.Size(129, 39);
            this.TileInputButton.TabIndex = 7;
            this.TileInputButton.Text = "Tile Input";
            this.TileInputButton.UseVisualStyleBackColor = true;
            this.TileInputButton.Click += new System.EventHandler(this.TileInputButton_Click);
            // 
            // resetBoardToolStripMenuItem
            // 
            this.resetBoardToolStripMenuItem.Name = "resetBoardToolStripMenuItem";
            this.resetBoardToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetBoardToolStripMenuItem.Text = "Reset Board";
            this.resetBoardToolStripMenuItem.Click += new System.EventHandler(this.ResetBoardToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.TileInputButton);
            this.Controls.Add(this.TileGroupBox);
            this.Controls.Add(this.GenerateBestMoveBtn);
            this.Controls.Add(this.GenerateAnagramBtn);
            this.Controls.Add(this.ResultDisplay);
            this.Controls.Add(this.GameBorder);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SpellCaster Scrabble Engine";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TileGroupBox.ResumeLayout(false);
            this.TileGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointValuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dictionaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameBoardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usageInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.Label GameBorder;
        private System.Windows.Forms.Label ResultDisplay;
        private System.Windows.Forms.Button GenerateAnagramBtn;
        private System.Windows.Forms.Button GenerateBestMoveBtn;
        private System.Windows.Forms.GroupBox TileGroupBox;
        private System.Windows.Forms.Label TileListLabel;
        private System.Windows.Forms.Button TileInputButton;
        private System.Windows.Forms.ToolStripMenuItem resetBoardToolStripMenuItem;
    }
}

