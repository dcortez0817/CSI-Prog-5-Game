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
            this.ClueDecision = new System.Windows.Forms.GroupBox();
            this.GenerateGrid = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Fing = new System.Windows.Forms.RadioButton();
            this.BloodS = new System.Windows.Forms.RadioButton();
            this.Related = new System.Windows.Forms.RadioButton();
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
            // ClueDecision
            // 
            this.ClueDecision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ClueDecision.BackColor = System.Drawing.Color.White;
            this.ClueDecision.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClueDecision.Controls.Add(this.Related);
            this.ClueDecision.Controls.Add(this.BloodS);
            this.ClueDecision.Controls.Add(this.Fing);
            this.ClueDecision.Controls.Add(this.GenerateGrid);
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
            // Fing
            // 
            this.Fing.Location = new System.Drawing.Point(14, 45);
            this.Fing.Name = "Fing";
            this.Fing.Size = new System.Drawing.Size(215, 36);
            this.Fing.TabIndex = 11;
            this.Fing.TabStop = true;
            this.Fing.Text = "Finger Prints";
            this.Fing.UseVisualStyleBackColor = true;
            // 
            // BloodS
            // 
            this.BloodS.Location = new System.Drawing.Point(14, 110);
            this.BloodS.Name = "BloodS";
            this.BloodS.Size = new System.Drawing.Size(215, 36);
            this.BloodS.TabIndex = 12;
            this.BloodS.TabStop = true;
            this.BloodS.Text = "Blood Scan";
            this.BloodS.UseVisualStyleBackColor = true;
            // 
            // Related
            // 
            this.Related.Location = new System.Drawing.Point(14, 175);
            this.Related.Name = "Related";
            this.Related.Size = new System.Drawing.Size(215, 36);
            this.Related.TabIndex = 13;
            this.Related.TabStop = true;
            this.Related.Text = "Related Evidence";
            this.Related.UseVisualStyleBackColor = true;
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
    }
}

