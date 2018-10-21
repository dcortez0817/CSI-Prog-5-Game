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
            this.StartBackground = new System.Windows.Forms.PictureBox();
            this.StartGame = new System.Windows.Forms.Button();
            this.Fing = new System.Windows.Forms.Button();
            this.BloodS = new System.Windows.Forms.Button();
            this.Related = new System.Windows.Forms.Button();
            this.ClueDecision = new System.Windows.Forms.GroupBox();
            this.RowsEntry = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ColumnsEntry = new System.Windows.Forms.TextBox();
            this.textGrid = new System.Windows.Forms.TextBox();
            this.GenerateGrid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StartBackground)).BeginInit();
            this.ClueDecision.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartBackground
            // 
            this.StartBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartBackground.Image = global::CSI_Prog5.Properties.Resources.Saw1;
            this.StartBackground.Location = new System.Drawing.Point(0, 0);
            this.StartBackground.Name = "StartBackground";
            this.StartBackground.Size = new System.Drawing.Size(1400, 784);
            this.StartBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StartBackground.TabIndex = 0;
            this.StartBackground.TabStop = false;
            // 
            // StartGame
            // 
            this.StartGame.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.StartGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(0)))));
            this.StartGame.ForeColor = System.Drawing.Color.Olive;
            this.StartGame.Location = new System.Drawing.Point(467, 691);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(467, 59);
            this.StartGame.TabIndex = 1;
            this.StartGame.Text = "Begin";
            this.StartGame.UseVisualStyleBackColor = false;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // Fing
            // 
            this.Fing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(64)))));
            this.Fing.ForeColor = System.Drawing.Color.White;
            this.Fing.Location = new System.Drawing.Point(105, 88);
            this.Fing.Name = "Fing";
            this.Fing.Size = new System.Drawing.Size(426, 63);
            this.Fing.TabIndex = 2;
            this.Fing.Text = "Finger Prints";
            this.Fing.UseVisualStyleBackColor = false;
            this.Fing.Click += new System.EventHandler(this.Fing_Click);
            // 
            // BloodS
            // 
            this.BloodS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(64)))));
            this.BloodS.Location = new System.Drawing.Point(105, 199);
            this.BloodS.Name = "BloodS";
            this.BloodS.Size = new System.Drawing.Size(426, 68);
            this.BloodS.TabIndex = 3;
            this.BloodS.Text = "Blood Samples";
            this.BloodS.UseVisualStyleBackColor = false;
            this.BloodS.Click += new System.EventHandler(this.BloodS_Click);
            // 
            // Related
            // 
            this.Related.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(64)))));
            this.Related.Location = new System.Drawing.Point(105, 315);
            this.Related.Name = "Related";
            this.Related.Size = new System.Drawing.Size(426, 63);
            this.Related.TabIndex = 4;
            this.Related.Text = "Evidence relating to the Crime";
            this.Related.UseVisualStyleBackColor = false;
            this.Related.Click += new System.EventHandler(this.Related_Click);
            // 
            // ClueDecision
            // 
            this.ClueDecision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ClueDecision.BackColor = System.Drawing.Color.White;
            this.ClueDecision.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClueDecision.Controls.Add(this.GenerateGrid);
            this.ClueDecision.Controls.Add(this.textGrid);
            this.ClueDecision.Controls.Add(this.ColumnsEntry);
            this.ClueDecision.Controls.Add(this.RowsEntry);
            this.ClueDecision.Controls.Add(this.Fing);
            this.ClueDecision.Controls.Add(this.Related);
            this.ClueDecision.Controls.Add(this.BloodS);
            this.ClueDecision.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClueDecision.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClueDecision.Location = new System.Drawing.Point(379, 145);
            this.ClueDecision.Name = "ClueDecision";
            this.ClueDecision.Size = new System.Drawing.Size(673, 514);
            this.ClueDecision.TabIndex = 5;
            this.ClueDecision.TabStop = false;
            this.ClueDecision.Text = "What kind of Clue do whish to discover?";
            this.ClueDecision.Visible = false;
            // 
            // RowsEntry
            // 
            this.RowsEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(64)))));
            this.RowsEntry.ForeColor = System.Drawing.Color.White;
            this.RowsEntry.Location = new System.Drawing.Point(105, 121);
            this.RowsEntry.Name = "RowsEntry";
            this.RowsEntry.Size = new System.Drawing.Size(426, 63);
            this.RowsEntry.TabIndex = 7;
            this.RowsEntry.Text = "Click here to enter the row size";
            this.RowsEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RowsEntry.Visible = false;
            this.RowsEntry.Enter += new System.EventHandler(this.RowsEntry_Enter);
            // 
            // ColumnsEntry
            // 
            this.ColumnsEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(64)))));
            this.ColumnsEntry.ForeColor = System.Drawing.Color.White;
            this.ColumnsEntry.Location = new System.Drawing.Point(105, 190);
            this.ColumnsEntry.Name = "ColumnsEntry";
            this.ColumnsEntry.Size = new System.Drawing.Size(426, 63);
            this.ColumnsEntry.TabIndex = 8;
            this.ColumnsEntry.Text = "Click here to enter the column size";
            this.ColumnsEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnsEntry.Visible = false;
            this.ColumnsEntry.Enter += new System.EventHandler(this.ColumnEntry_Enter);
            // 
            // textGrid
            // 
            this.textGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(64)))));
            this.textGrid.ForeColor = System.Drawing.Color.White;
            this.textGrid.Location = new System.Drawing.Point(105, 300);
            this.textGrid.Multiline = true;
            this.textGrid.Name = "textGrid";
            this.textGrid.ReadOnly = true;
            this.textGrid.Size = new System.Drawing.Size(426, 161);
            this.textGrid.TabIndex = 9;
            this.textGrid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textGrid.Visible = false;
            // 
            // GenerateGrid
            // 
            this.GenerateGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(64)))));
            this.GenerateGrid.Location = new System.Drawing.Point(261, 467);
            this.GenerateGrid.Name = "GenerateGrid";
            this.GenerateGrid.Size = new System.Drawing.Size(103, 41);
            this.GenerateGrid.TabIndex = 10;
            this.GenerateGrid.Text = "Generate Grid";
            this.GenerateGrid.UseVisualStyleBackColor = false;
            this.GenerateGrid.Visible = false;
            this.GenerateGrid.Click += new System.EventHandler(this.GenerateGrid_Click);
            // 
            // SawGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(28F, 54F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 784);
            this.Controls.Add(this.ClueDecision);
            this.Controls.Add(this.StartGame);
            this.Controls.Add(this.StartBackground);
            this.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SawGame";
            this.Text = "Do you Want to Play a Game?";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.StartBackground)).EndInit();
            this.ClueDecision.ResumeLayout(false);
            this.ClueDecision.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox StartBackground;
        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.Button Fing;
        private System.Windows.Forms.Button BloodS;
        private System.Windows.Forms.Button Related;
        private System.Windows.Forms.GroupBox ClueDecision;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox RowsEntry;
        private System.Windows.Forms.TextBox ColumnsEntry;
        private System.Windows.Forms.TextBox textGrid;
        private System.Windows.Forms.Button GenerateGrid;
    }
}

