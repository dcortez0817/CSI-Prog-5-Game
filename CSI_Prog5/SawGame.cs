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
using CSIGame;//needed for Analyzer

namespace CSI_Prog5
{
    public partial class SawGame : Form
    {
        private Analyzer[] SC;//creates an array of Analyzers
        private SoundPlayer playsound;//provides saw sound to the form
        private SoundPlayer playstatic;//provides tv static sound to the form
        Image st = Properties.Resources.stat;//static background
        Image bth = Properties.Resources.bathroom;//creepy bathroom background
        Image saw = Properties.Resources.Saw;//blank saw background

        public SawGame()
        {
            InitializeComponent();
            playsound = new SoundPlayer("Do you wanna play a game.wav");
            playsound.PlayLooping();
        }

        //button begin game
        private void StartGame_Click(object sender, EventArgs e)
        {
            StartBackground.Image = saw;
            playsound.Stop();
            //prints instructions
            MessageBox.Show("A crime has been committed on the very grounds you stand.\n" +
                "\nYou must discover clues that could possibily solve the mystery.\n" +
                "\nBUT THERE'S A CATCH.\n\nSolve the mystery or suffer the penalty.", "Objective");
            
            staticEffect();
            StartBackground.Image = st;//quick static image
            StartGame.Visible = false;//gets rid of button
            StartBackground.Image = bth;//displays gameplay background
        }
        
        //quick static image and sound
        private void staticEffect()
        {
            playstatic = new SoundPlayer("TV Static Sound Effect.wav");
            StartBackground.Image = st;
            playstatic.Play();
        }
    }
}
