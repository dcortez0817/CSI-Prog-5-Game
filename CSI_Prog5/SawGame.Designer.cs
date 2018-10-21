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
            ((System.ComponentModel.ISupportInitialize)(this.StartBackground)).BeginInit();
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
            this.StartGame.BackColor = System.Drawing.Color.Black;
            this.StartGame.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StartGame.ForeColor = System.Drawing.Color.Red;
            this.StartGame.Location = new System.Drawing.Point(0, 739);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(1400, 45);
            this.StartGame.TabIndex = 1;
            this.StartGame.Text = "Begin";
            this.StartGame.UseVisualStyleBackColor = false;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // SawGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(28F, 54F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 784);
            this.Controls.Add(this.StartGame);
            this.Controls.Add(this.StartBackground);
            this.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SawGame";
            this.Text = "Do you Want to Play a Game?";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.StartBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox StartBackground;
        private System.Windows.Forms.Button StartGame;
    }
}

