using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace CSI_Prog5
{
    public partial class SawGame : Form
    {
        private SoundPlayer playsound;

        //static background
        Image st = Image.FromFile(@"C:\Users\richard cortez\Documents\C#\CSI\CSIGame\CSIGame\Resources\static.jpeg");
        //creepy bathroom background
        Image bth = Image.FromFile(@"C:\Users\richard cortez\Documents\C#\CSI\CSIGame\CSIGame\Resources\bathroom.jpg");

        public SawGame()
        {
            InitializeComponent();
            playsound = new SoundPlayer("Do you wanna play a game.wav");//provides sound to the form
            playsound.Play();
        }

        //button begin game
        private void StartGame_Click(object sender, EventArgs e)
        {
            //prints instructions
            MessageBox.Show("A crime has been committed on the very grounds you stand.\n" +
                "\nYou must discover clues that could possibily solve the mystery.\n" +
                "\nBUT THERE'S A CATCH.\n\nSolve the mystery or suffer the penalty.", "Objective");

            StartBackground.Visible = false;//gets rid of gif
            BackgroundImage = st;//quick static image
            StartGame.Visible = false;//gets rid of button
            BackgroundImage = bth;//displays gameplay background
            StartGame.Visible = true;
        }
    }
}
