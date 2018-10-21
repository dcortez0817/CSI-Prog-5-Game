/*Darien Cortez and Buddy Smith
 * Program 5 - Finding Evidence Game
 * This program utilizes polymorphism and inheritance to derive from an
 * abstract analyzer base class and display three different scan Analyzers.
 * The program allows the user to decide on the kind of evidence they wish to
 * find -- both the BloodScan and the providingEvidence Analyzers use visual grids
 * while the fingerprint Analyzer uses a textbox grid. Like the last program, the
 * user's stats are provided at the end.
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

            //stores the different Analyzers in an array
            SC[0] = new Finger(row, col);
            //SC[1] = new BloodScan(row, col);
            //SC[2] = new SupportingEvidence(row, col);
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
        
        //quick static image and sound efect
        private void staticEffect()
        {
            playstatic = new SoundPlayer("TV Static Sound Effect.wav");
            StartBackground.Image = st;
            playstatic.Play();
            StartBackground.Image = bth;//displays gameplay background
        }

        private void Fing_Click(object sender, EventArgs e)
        {
            i = 0;
            staticEffect();
            ButtonClick();
        }

        private void BloodS_Click(object sender, EventArgs e)
        {
            i = 1;
            staticEffect();
            ButtonClick();
        }

        private void Related_Click(object sender, EventArgs e)
        {
            i = 2;
            staticEffect();
            ButtonClick();
        }

        private void ButtonClick()
        {
            ClueDecision.Text = "Shall We Begin?";
            RowsEntry.Visible = true;
            Fing.Visible = false;
            BloodS.Visible = false;
            Related.Visible = false;
            GenerateGrid.Visible = true;
        }

        private void RowsEntry_Enter(object sender, EventArgs e)
        {
            RowsEntry.Text = "";
            Int16.TryParse(RowsEntry.Text, out row);
            ColumnsEntry.Visible = true;

        }

        private void ColumnEntry_Enter(object sender, EventArgs e)
        {
            ColumnsEntry.Text = "";
            Int16.TryParse(RowsEntry.Text, out col);
            
        }

        private void GenerateGrid_Click(object sender, EventArgs e)
        {
            if (i == 0)
                TextBoxGrid();
        }

        private void TextBoxGrid()
        {
            textGrid.Visible = true;
            textGrid.Text = SC[i].ToString();
        }

        //stores 3 types of Analyzers in an array
        Analyzer[] SC;
        int i;//index for SC

        //row & col are the grid dimensions
        //rowG & colG are the dimensions of the users guess
        short row, col, rowG, colG; 

        private SoundPlayer playsound;//provides saw sound to the form
        private SoundPlayer playstatic;//provides tv static sound to the form

        Image st = Properties.Resources.stat;//static background
        Image bth = Properties.Resources.bathroom;//creepy bathroom background
        Image saw = Properties.Resources.Saw;//blank saw background
    }
}
