/*Darien Cortez and Buddy Smith
 * Program 5 - Finding Evidence Game
 * This program utilizes polymorphism and inheritance to derive from an
 * abstract analyzer base class and display different scan Analyzers.
 * The program allows the user to decide on the kind of evidence they wish to
 * find, allows the user to guess the row and column placement of the evidence,
 * displays a 2D array containg picture boxes, and shows the user their stats
 * at the end of the game.
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace CSI_Prog5
{
    public partial class SawGame : Form
    {
        public SawGame()
        {
            InitializeComponent();

            //continuosly plays saw recording
            playsound = new SoundPlayer("Do you wanna play a game.wav");
            playsound.PlayLooping();

            //makes the clue group box transparent
            ClueDecision.Parent = StartBackground;
            ClueDecision.BackColor = Color.Transparent;
        }

        //button to start the game
        private void StartGame_Click(object sender, EventArgs e)
        {
            StartBackground.Image = saw;
            playsound.Stop();
            //prints instructions
            MessageBox.Show("A crime has been committed on the very grounds you stand.\n" +
                "\nYou must discover clues that could possibily solve the mystery.\n" +
                "\nBUT THERE'S A CATCH.\n\nSolve the mystery or suffer the penalty.", "Objective");
            
            staticEffect();
            StartGame.Visible = false;//gets rid of button
            ClueDecision.Visible = true;//clues group for the game
        }
        
        //this functions gives a quick tv static image and tv static sound efect
        private void staticEffect()
        {
            playstatic = new SoundPlayer("TV Static Sound Effect.wav");
            StartBackground.Image = st;
            playstatic.Play();
            StartBackground.Image = bth;//displays gameplay background
        }
        
        //generalized button function that will be used by all the analyzer
        //radio buttons. This function gives off the static sound effect,
        //displays the ClueDecision groupbox, and makes the rows and columns
        //entry textboxes visible
        private void ButtonClick()
        {
            staticEffect();
            ClueDecision.Text = "Shall We Begin?";//changes titleof groupBox
            RowEntry.Visible = true;//user row input
            ColumnEntry.Visible = true;//user column input
        }
        
        //radiobutton to initialize a fingerprint scanner and disable
        //the other button choices
        private void Fing_CheckedChanged(object sender, EventArgs e)
        {
            analyzer = new FPScanner(row, col);
            BloodS.Enabled = false;
            Related.Enabled = false;
            ButtonClick();//calls buttonclick function
        }

        //radiobutton to initialize a blood scanner and disable
        //the other button choices
        private void BloodS_CheckedChanged(object sender, EventArgs e)
        {
            analyzer = new BloodScanner(row, col);
            Fing.Enabled = false;
            Related.Enabled = false;
            ButtonClick();//calls buttonclick function
        }

        //radiobutton to initialize a scanner full of supporting evidence 
        //and disable the other button choices
        private void Related_CheckedChanged(object sender, EventArgs e)
        {
            analyzer = new SupportingEvidence(row, col);
            BloodS.Enabled = false;
            Fing.Enabled = false;
            ButtonClick();//calls buttonclick function
        }

        //**********************************************************************
        //user input for how many rows and columns they want on the grid
        //_Enter and _Leave makes input act as placeholder
        //**********************************************************************
        private void RowEntry_Enter(object sender, EventArgs e)
        {
            if (RowEntry.Text == "Enter the Row Size:")
                RowEntry.Text = "";

            ColumnEntry.Enabled = true;
        }
        private void RowEntry_Leave(object sender, EventArgs e)
        {
            if (RowEntry.Text == "")
                RowEntry.Text = "Enter the Row Size:";

            Int32.TryParse(RowEntry.Text, out row);
        }

        private void ColumnEntry_Enter(object sender, EventArgs e)
        {
            if (ColumnEntry.Text == "Enter the Column Size:")
                ColumnEntry.Text = "";

            Int32.TryParse(ColumnEntry.Text, out col);

            GenerateGrid.Visible = true;
        }

        private void ColumnEntry_Leave(object sender, EventArgs e)
        {
            if (ColumnEntry.Text == "")
                ColumnEntry.Text = "Enter the Column Size:";

            Int32.TryParse(ColumnEntry.Text, out col);
        }
        //**********************************************************************
        //End of _Enter and _Leave functions for rows and columns
        //**********************************************************************

        //button to generate the grid; calls the DisplayGrid function
        private void GenerateGrid_Click(object sender, EventArgs e)
        {
            staticEffect();//gives tv static effect
            DisplayGrid();
        }

        //creates a 2D array of pictureboxes
        private void DisplayGrid ()
        {
            grid = new PictureBox[row, col];
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    grid[i, j] = new PictureBox();
                    grid[i, j].BackColor = Color.White;
                    //grid.Image = Properties.Resources.tilde;
                    //grid.SizeMode = PictureBoxSizeMode.StretchImage;
                    grid[i, j].Height = 50;
                    grid[i, j].Width = 50;
                    grid[i, j].Location = new Point(620 + (i *55), 50 + (j*55));
                    grid[i, j].Anchor = AnchorStyles.Top;
                    ClueDecision.Controls.Add(grid[i,j]);
                }
            }
        }
        
        PictureBox[,] grid;//creates a 2D array and calls it grid
        Analyzer analyzer;//intializes an analyzer

        //row & col - grid dimensions that the user sets
        //rowG & colG - grid points of the users guess
        //i & j- indices for the grid you display
        int row, col, rowG, colG, i = 0, j = 0; 

        private SoundPlayer playsound;//provides saw sound to the form
        private SoundPlayer playstatic;//provides tv static sound to the form


        Image st = Properties.Resources.stat;//static background
        Image bth = Properties.Resources.bathroom;//creepy bathroom background
        Image saw = Properties.Resources.Saw;//blank saw background    
    }
}
