namespace CSI_Prog5
{
    partial class SawGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SawGame));
            this.StartGame = new System.Windows.Forms.Button();
            this.ClueDecision = new System.Windows.Forms.GroupBox();
            this.Stats = new System.Windows.Forms.GroupBox();
            this.CluesFound = new System.Windows.Forms.Label();
            this.Clues = new System.Windows.Forms.Label();
            this.Last = new System.Windows.Forms.Label();
            this.LastGuess = new System.Windows.Forms.Label();
            this.Guesses = new System.Windows.Forms.Label();
            this.GuessAmount = new System.Windows.Forms.Label();
            this.Hair = new System.Windows.Forms.RadioButton();
            this.GuessGrid = new System.Windows.Forms.Button();
            this.ColumnGuess = new System.Windows.Forms.TextBox();
            this.RowGuess = new System.Windows.Forms.TextBox();
            this.ColumnEntry = new System.Windows.Forms.TextBox();
            this.RowEntry = new System.Windows.Forms.TextBox();
            this.Related = new System.Windows.Forms.RadioButton();
            this.BloodS = new System.Windows.Forms.RadioButton();
            this.Fing = new System.Windows.Forms.RadioButton();
            this.GenerateGrid = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.StartBackground = new System.Windows.Forms.PictureBox();
            this.Restart = new System.Windows.Forms.Button();
            this.GiveUp = new System.Windows.Forms.Button();
            this.ClueDecision.SuspendLayout();
            this.Stats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // StartGame
            // 
            this.StartGame.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.StartGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(0)))));
            this.StartGame.ForeColor = System.Drawing.Color.Olive;
            this.StartGame.Location = new System.Drawing.Point(615, 731);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(467, 59);
            this.StartGame.TabIndex = 1;
            this.StartGame.Text = "Begin";
            this.StartGame.UseVisualStyleBackColor = false;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // ClueDecision
            // 
            this.ClueDecision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ClueDecision.BackColor = System.Drawing.Color.White;
            this.ClueDecision.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClueDecision.Controls.Add(this.GiveUp);
            this.ClueDecision.Controls.Add(this.Stats);
            this.ClueDecision.Controls.Add(this.Hair);
            this.ClueDecision.Controls.Add(this.GuessGrid);
            this.ClueDecision.Controls.Add(this.ColumnGuess);
            this.ClueDecision.Controls.Add(this.RowGuess);
            this.ClueDecision.Controls.Add(this.ColumnEntry);
            this.ClueDecision.Controls.Add(this.RowEntry);
            this.ClueDecision.Controls.Add(this.Related);
            this.ClueDecision.Controls.Add(this.BloodS);
            this.ClueDecision.Controls.Add(this.Fing);
            this.ClueDecision.Controls.Add(this.GenerateGrid);
            this.ClueDecision.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClueDecision.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClueDecision.Location = new System.Drawing.Point(209, 79);
            this.ClueDecision.Name = "ClueDecision";
            this.ClueDecision.Size = new System.Drawing.Size(1262, 646);
            this.ClueDecision.TabIndex = 5;
            this.ClueDecision.TabStop = false;
            this.ClueDecision.Text = "What kind of Clue do whish to discover?";
            this.ClueDecision.Visible = false;
            // 
            // Stats
            // 
            this.Stats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(64)))));
            this.Stats.Controls.Add(this.CluesFound);
            this.Stats.Controls.Add(this.Clues);
            this.Stats.Controls.Add(this.Last);
            this.Stats.Controls.Add(this.LastGuess);
            this.Stats.Controls.Add(this.Guesses);
            this.Stats.Controls.Add(this.GuessAmount);
            this.Stats.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stats.ForeColor = System.Drawing.Color.White;
            this.Stats.Location = new System.Drawing.Point(14, 338);
            this.Stats.Name = "Stats";
            this.Stats.Size = new System.Drawing.Size(254, 270);
            this.Stats.TabIndex = 22;
            this.Stats.TabStop = false;
            this.Stats.Text = "Stats Board";
            this.Stats.Visible = false;
            // 
            // CluesFound
            // 
            this.CluesFound.Location = new System.Drawing.Point(15, 193);
            this.CluesFound.Name = "CluesFound";
            this.CluesFound.Size = new System.Drawing.Size(137, 41);
            this.CluesFound.TabIndex = 25;
            this.CluesFound.Text = "Clues Found:";
            // 
            // Clues
            // 
            this.Clues.Location = new System.Drawing.Point(189, 193);
            this.Clues.Name = "Clues";
            this.Clues.Size = new System.Drawing.Size(59, 41);
            this.Clues.TabIndex = 24;
            // 
            // Last
            // 
            this.Last.Location = new System.Drawing.Point(170, 129);
            this.Last.Name = "Last";
            this.Last.Size = new System.Drawing.Size(78, 41);
            this.Last.TabIndex = 23;
            // 
            // LastGuess
            // 
            this.LastGuess.Location = new System.Drawing.Point(15, 129);
            this.LastGuess.Name = "LastGuess";
            this.LastGuess.Size = new System.Drawing.Size(137, 41);
            this.LastGuess.TabIndex = 22;
            this.LastGuess.Text = "Last Guess:";
            // 
            // Guesses
            // 
            this.Guesses.Location = new System.Drawing.Point(15, 69);
            this.Guesses.Name = "Guesses";
            this.Guesses.Size = new System.Drawing.Size(137, 41);
            this.Guesses.TabIndex = 21;
            this.Guesses.Text = "Guesses:";
            // 
            // GuessAmount
            // 
            this.GuessAmount.Location = new System.Drawing.Point(189, 69);
            this.GuessAmount.Name = "GuessAmount";
            this.GuessAmount.Size = new System.Drawing.Size(59, 41);
            this.GuessAmount.TabIndex = 20;
            // 
            // Hair
            // 
            this.Hair.Location = new System.Drawing.Point(14, 244);
            this.Hair.Name = "Hair";
            this.Hair.Size = new System.Drawing.Size(215, 63);
            this.Hair.TabIndex = 19;
            this.Hair.TabStop = true;
            this.Hair.Text = "Hair Fibers";
            this.Hair.UseVisualStyleBackColor = true;
            this.Hair.CheckedChanged += new System.EventHandler(this.Hair_CheckedChanged);
            // 
            // GuessGrid
            // 
            this.GuessGrid.BackColor = System.Drawing.Color.Gray;
            this.GuessGrid.ForeColor = System.Drawing.Color.White;
            this.GuessGrid.Location = new System.Drawing.Point(300, 407);
            this.GuessGrid.Name = "GuessGrid";
            this.GuessGrid.Size = new System.Drawing.Size(243, 41);
            this.GuessGrid.TabIndex = 18;
            this.GuessGrid.Text = "Guess";
            this.GuessGrid.UseVisualStyleBackColor = false;
            this.GuessGrid.Visible = false;
            this.GuessGrid.Click += new System.EventHandler(this.GuessGrid_Click);
            // 
            // ColumnGuess
            // 
            this.ColumnGuess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(64)))));
            this.ColumnGuess.ForeColor = System.Drawing.Color.White;
            this.ColumnGuess.Location = new System.Drawing.Point(289, 338);
            this.ColumnGuess.Name = "ColumnGuess";
            this.ColumnGuess.Size = new System.Drawing.Size(266, 63);
            this.ColumnGuess.TabIndex = 17;
            this.ColumnGuess.Text = "Enter your Column Guess:";
            this.ColumnGuess.Visible = false;
            this.ColumnGuess.Enter += new System.EventHandler(this.ColumnGuess_Enter);
            this.ColumnGuess.Leave += new System.EventHandler(this.ColumnGuess_Leave);
            // 
            // RowGuess
            // 
            this.RowGuess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(64)))));
            this.RowGuess.ForeColor = System.Drawing.Color.White;
            this.RowGuess.Location = new System.Drawing.Point(289, 269);
            this.RowGuess.Name = "RowGuess";
            this.RowGuess.Size = new System.Drawing.Size(266, 63);
            this.RowGuess.TabIndex = 16;
            this.RowGuess.Text = "Enter your Row Guess:";
            this.RowGuess.Visible = false;
            this.RowGuess.Enter += new System.EventHandler(this.RowGuess_Enter);
            this.RowGuess.Leave += new System.EventHandler(this.RowGuess_Leave);
            // 
            // ColumnEntry
            // 
            this.ColumnEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(64)))));
            this.ColumnEntry.Enabled = false;
            this.ColumnEntry.ForeColor = System.Drawing.Color.White;
            this.ColumnEntry.Location = new System.Drawing.Point(289, 110);
            this.ColumnEntry.Name = "ColumnEntry";
            this.ColumnEntry.Size = new System.Drawing.Size(266, 63);
            this.ColumnEntry.TabIndex = 15;
            this.ColumnEntry.Text = "Enter the Column Size:";
            this.ColumnEntry.Visible = false;
            this.ColumnEntry.Enter += new System.EventHandler(this.ColumnEntry_Enter);
            this.ColumnEntry.Leave += new System.EventHandler(this.ColumnEntry_Leave);
            // 
            // RowEntry
            // 
            this.RowEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(64)))));
            this.RowEntry.ForeColor = System.Drawing.Color.White;
            this.RowEntry.Location = new System.Drawing.Point(289, 45);
            this.RowEntry.Name = "RowEntry";
            this.RowEntry.Size = new System.Drawing.Size(266, 63);
            this.RowEntry.TabIndex = 14;
            this.RowEntry.Text = "Enter the Row Size:";
            this.RowEntry.Visible = false;
            this.RowEntry.Enter += new System.EventHandler(this.RowEntry_Enter);
            this.RowEntry.Leave += new System.EventHandler(this.RowEntry_Leave);
            // 
            // Related
            // 
            this.Related.Location = new System.Drawing.Point(14, 175);
            this.Related.Name = "Related";
            this.Related.Size = new System.Drawing.Size(215, 63);
            this.Related.TabIndex = 13;
            this.Related.TabStop = true;
            this.Related.Text = "Related Evidence";
            this.Related.UseVisualStyleBackColor = true;
            this.Related.CheckedChanged += new System.EventHandler(this.Related_CheckedChanged);
            // 
            // BloodS
            // 
            this.BloodS.Location = new System.Drawing.Point(14, 110);
            this.BloodS.Name = "BloodS";
            this.BloodS.Size = new System.Drawing.Size(215, 63);
            this.BloodS.TabIndex = 12;
            this.BloodS.TabStop = true;
            this.BloodS.Text = "Blood Scan";
            this.BloodS.UseVisualStyleBackColor = true;
            this.BloodS.CheckedChanged += new System.EventHandler(this.BloodS_CheckedChanged);
            // 
            // Fing
            // 
            this.Fing.Location = new System.Drawing.Point(14, 45);
            this.Fing.Name = "Fing";
            this.Fing.Size = new System.Drawing.Size(215, 63);
            this.Fing.TabIndex = 11;
            this.Fing.TabStop = true;
            this.Fing.Text = "Finger Prints";
            this.Fing.UseVisualStyleBackColor = true;
            this.Fing.CheckedChanged += new System.EventHandler(this.Fing_CheckedChanged);
            // 
            // GenerateGrid
            // 
            this.GenerateGrid.BackColor = System.Drawing.Color.Gray;
            this.GenerateGrid.Location = new System.Drawing.Point(300, 175);
            this.GenerateGrid.Name = "GenerateGrid";
            this.GenerateGrid.Size = new System.Drawing.Size(243, 41);
            this.GenerateGrid.TabIndex = 10;
            this.GenerateGrid.Text = "Generate Grid";
            this.GenerateGrid.UseVisualStyleBackColor = false;
            this.GenerateGrid.Visible = false;
            this.GenerateGrid.Click += new System.EventHandler(this.GenerateGrid_Click);
            // 
            // StartBackground
            // 
            this.StartBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartBackground.Image = global::CSI_Prog5.Properties.Resources.Saw1;
            this.StartBackground.Location = new System.Drawing.Point(0, 0);
            this.StartBackground.Name = "StartBackground";
            this.StartBackground.Size = new System.Drawing.Size(1696, 824);
            this.StartBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StartBackground.TabIndex = 0;
            this.StartBackground.TabStop = false;
            // 
            // Restart
            // 
            this.Restart.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restart.ForeColor = System.Drawing.Color.Red;
            this.Restart.Location = new System.Drawing.Point(12, 12);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(121, 47);
            this.Restart.TabIndex = 23;
            this.Restart.Text = "Restart";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Visible = false;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // GiveUp
            // 
            this.GiveUp.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiveUp.ForeColor = System.Drawing.Color.Red;
            this.GiveUp.Location = new System.Drawing.Point(343, 490);
            this.GiveUp.Name = "GiveUp";
            this.GiveUp.Size = new System.Drawing.Size(143, 68);
            this.GiveUp.TabIndex = 24;
            this.GiveUp.Text = "Give Up";
            this.GiveUp.UseVisualStyleBackColor = true;
            this.GiveUp.Visible = false;
            this.GiveUp.Click += new System.EventHandler(this.GiveUp_Click);
            // 
            // SawGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(28F, 54F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1696, 824);
            this.Controls.Add(this.ClueDecision);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.StartGame);
            this.Controls.Add(this.StartBackground);
            this.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SawGame";
            this.Text = "Do you Want to Play a Game?";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ClueDecision.ResumeLayout(false);
            this.ClueDecision.PerformLayout();
            this.Stats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StartBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox StartBackground;
        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.GroupBox ClueDecision;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button GenerateGrid;
        private System.Windows.Forms.RadioButton Related;
        private System.Windows.Forms.RadioButton BloodS;
        private System.Windows.Forms.RadioButton Fing;
        private System.Windows.Forms.TextBox ColumnEntry;
        private System.Windows.Forms.TextBox RowEntry;
        private System.Windows.Forms.Button GuessGrid;
        private System.Windows.Forms.TextBox ColumnGuess;
        private System.Windows.Forms.TextBox RowGuess;
        private System.Windows.Forms.RadioButton Hair;
        private System.Windows.Forms.Label GuessAmount;
        private System.Windows.Forms.Label Guesses;
        private System.Windows.Forms.GroupBox Stats;
        private System.Windows.Forms.Label Last;
        private System.Windows.Forms.Label LastGuess;
        private System.Windows.Forms.Label CluesFound;
        private System.Windows.Forms.Label Clues;
        private System.Windows.Forms.Button GiveUp;
        private System.Windows.Forms.Button Restart;
    }
}

