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
            intro = new SoundPlayer("Do you wanna play a game.wav");
            intro.PlayLooping();

            //makes the clue group box transparent
            ClueDecision.Parent = StartBackground;
            ClueDecision.BackColor = Color.Transparent;

            NumberOfGuesses = 0;//keeps track of user guesses
            FirstClueNotFound = true;//for first clue
        }

        //button to start the game
        private void StartGame_Click(object sender, EventArgs e)
        {
            StartBackground.Image = saw;//background sets to photo after button click
            intro.Stop();//stops looping the saw intro

            //music throughout the entire game
            gameAudio = new SoundPlayer("Pain.wav");
            gameAudio.PlayLooping();

            //prints instructions
            MessageBox.Show("A crime has been committed on the very grounds you stand.\n" +
                "\nYou must discover clues that could possibily solve the mystery.\n" +
                "\nBUT THERE'S A CATCH.\n\nSolve the mystery or suffer the punishment.", "Objective");
            
            StartBackground.Image = bth;//gives the background a creepy bathroom setting
            StartGame.Visible = false;//gets rid of button to start the game
            ClueDecision.Visible = true;//group box for the entire game
        }
        
        //generalized button function that will be used by all the analyzer
        //radio buttons. This function gives off the static sound effect,
        //displays the ClueDecision groupbox, and makes the rows and columns
        //entry textboxes visible
        private void ButtonClick()
        {
            RowEntry.Visible = true;//user row input
            ColumnEntry.Visible = true;//user column input
        }
        
        //radiobutton to initialize a fingerprint scanner and disable
        //the other button choices
        private void Fing_CheckedChanged(object sender, EventArgs e)
        {
            radioValue = 1;//gives it a value of 1 for the switch statement below
            BloodS.Enabled = false;
            Related.Enabled = false;
            Hair.Enabled = false;
            ClueDecision.Text = "Searching for finger prints...";//changes titleof groupBox
            ButtonClick();//calls buttonclick function
        }

        //radiobutton to initialize a blood scanner and disable
        //the other button choices
        private void BloodS_CheckedChanged(object sender, EventArgs e)
        {
            radioValue = 2;//gives it a value of 2 for the switch statement below
            Fing.Enabled = false;
            Related.Enabled = false;
            Hair.Enabled = false;
            ClueDecision.Text = "Searching for traces of blood...";//changes titleof groupBox
            ButtonClick();//calls buttonclick function
        }

        //radiobutton to initialize a scanner full of supporting evidence 
        //and disable the other button choices
        private void Related_CheckedChanged(object sender, EventArgs e)
        {
            radioValue = 3;//gives it a value of 3 for the switch statement below
            BloodS.Enabled = false;
            Fing.Enabled = false;
            Hair.Enabled = false;
            ClueDecision.Text = "Searching for evidence related to the crime...";//changes titleof groupBox
            ButtonClick();//calls buttonclick function
        }

        private void Hair_CheckedChanged(object sender, EventArgs e)
        {
            radioValue = 4;//gives it a value of 4 for the switch statement below
            BloodS.Enabled = false;
            Fing.Enabled = false;
            Related.Enabled = false;
            ClueDecision.Text = "Searching for Hair/Fibers/etc...";//changes titleof groupBox
            ButtonClick();//calls buttonclick function
        }

        //**********************************************************************
        //these following 8 functions below deal with user input
        //they allow the user to input the row size, column size, row position
        //guess, and column position guess
        //_Enter and _Leave makes input act as placeholder
        //**********************************************************************
        private void RowEntry_Enter(object sender, EventArgs e)
        {
            if (RowEntry.Text == "Enter the Row Size:")
            {
                RowEntry.Text = "";
                ColumnEntry.Enabled = true;//let's user enter the column size after rows are entered
            }
        }
        private void RowEntry_Leave(object sender, EventArgs e)
        {
            if (RowEntry.Text == "")
            {
                RowEntry.Text = "Enter the Row Size:";
                
            }
            Int32.TryParse(RowEntry.Text, out row);//puts result in row
        }

        private void ColumnEntry_Enter(object sender, EventArgs e)
        {
            if (ColumnEntry.Text == "Enter the Column Size:")
            {
                ColumnEntry.Text = "";
                
            }
            GenerateGrid.Visible = true;//makes the generateGrid button visible after columns are entered
        }

        private void ColumnEntry_Leave(object sender, EventArgs e)
        {
            if (ColumnEntry.Text == "")
            {
                ColumnEntry.Text = "Enter the Column Size:";
                
            }
            Int32.TryParse(ColumnEntry.Text, out col);//puts result in col
        }

        private void RowGuess_Enter(object sender, EventArgs e)
        {
            if (RowGuess.Text == "Enter your Row Guess:")
            {
                RowGuess.Text = "";
            }
        }

        private void RowGuess_Leave(object sender, EventArgs e)
        {
            if (RowGuess.Text == "")
            {
                RowGuess.Text = "Enter your Row Guess:";

            }
            Int32.TryParse(RowGuess.Text, out rowG);//puts result in rowG

            //decrements the value of roG because the grid starts at i and j = 0
            if (rowG > 1)
                rowG--;
            else rowG = 0;
        }

        private void ColumnGuess_Enter(object sender, EventArgs e)
        {
            if (ColumnGuess.Text == "Enter your Column Guess:")
            {
                ColumnGuess.Text = "";
            }
           
            //makes the guess button available after the user guesses a column position
            GuessGrid.Visible = true;
        }

        private void ColumnGuess_Leave(object sender, EventArgs e)
        {
            if (ColumnGuess.Text == "")
            {
                ColumnGuess.Text = "Enter your Column Guess:";

            }
            Int32.TryParse(ColumnGuess.Text, out colG);//puts result in colG

            //decrements the value of roG because the grid starts at i and j = 0
            if (colG > 1)
                colG--;
            else colG = 0;
        }
        //*************************************************************************
        //End of _Enter and _Leave functions for row and column guesses and sizes
        //*************************************************************************

        //button to generate the grid; calls the DisplayGrid function
        private void GenerateGrid_Click(object sender, EventArgs e)
        {
            //only allows the dimensions to be between 2x2 and 10x10
            if (row > 10 || row < 2 || col > 10 || col < 2)
                MessageBox.Show("You must enter numbers between 2 and 10, you hooligan.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                //switch statemnet to decide which analyzer is being used
                switch (radioValue)
                {
                    case 1:
                        analyzer = new FPScanner(row, col);//finger analyzer
                        break;

                    case 2:
                        analyzer = new BloodScanner(row, col);//blood analyzer
                        break;

                    case 3:
                        analyzer = new SupportingEvidence(row, col);//supporting evidence analyzer
                        break;

                    case 4:
                        analyzer = new HairFiberScan(row, col);//hair etc. analyzer
                        break;
                }

                DisplayGrid();//calls this function to print the grid to the ClueDecision GroupBox

                //these are self explanatory
                RowEntry.Enabled = false;
                ColumnEntry.Enabled = false;
                GenerateGrid.Enabled = false;
                RowGuess.Visible = true;
                ColumnGuess.Visible = true;
                Restart.Visible = true;
            }
        }

        //creates a 2D array of pictureboxes and sets their properties
        private void DisplayGrid ()
        {
            grid = new PictureBox[row, col];//initializes a 2D array of pictureBoxes

            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    grid[i, j] = new PictureBox();//each individual picturebox
                    grid[i, j].BackColor = Color.White;//sets background to white
                    grid[i, j].Image = Properties.Resources.tilde;
                    grid[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                    grid[i, j].Height = 50;
                    grid[i, j].Width = 50;
                    //sets the location and adds on to each indiviual picture boxes location
                    grid[i, j].Location = new Point(620 + (i * 55), 50 + (j * 55));
                    grid[i, j].Anchor = AnchorStyles.Top;
                    ClueDecision.Controls.Add(grid[i, j]);//adds each image
                }
            }
        }

        //button to update the grid after a guess.
        private void GuessGrid_Click(object sender, EventArgs e)
        {
            Stats.Visible = true;//displays stats board

            //only allows the guesses for dimensions to be within the grid dimensions
            if (rowG >= row || rowG < 0 || colG >= col || colG < 0)
                MessageBox.Show("You must enter a guess within the dimensions of the evidence " +
                    "grid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //sets the current picture box to what was passed by the CheckIfClue function
                grid[colG, rowG].Image = analyzer.CheckIfClue(rowG, colG);
                NumberOfGuesses++;//updates the amount of guesses
                CheckClues();//calls checkclues function to see which message box etc needs to appear
                RowGuess.Text = "Enter your Row Guess:";//reassigns row guess text after each guess
                ColumnGuess.Text = "Enter your Column Guess:";//reassigns column guess text after each guess
                GuessAmount.Text = NumberOfGuesses.ToString();//displays amount of guesses on this label
                Last.Text = "[" + (rowG + 1) + ", " + (colG + 1) + "]";//outputs the last guess pont
                Clues.Text = analyzer.CluesFound.ToString();//tells how many clues were found
                GiveUp.Visible = true;//makes the give up option assesible after first guess
            }
        }

        private void CheckClues()
        {
            //if the image of the current picturebox is the first clue
            //and not a tilde or a hint, this function prints the messageBox
            if (analyzer.CluesFound == 1 && FirstClueNotFound)
            {
                FirstClueNotFound = false;
                MessageBox.Show("Not Bad.. You might Escape after all.", "You discovered the first clue", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                aClue = grid[colG, rowG].Image;//sets the first clue answer to aClue 
                ResetGrid();//resets the grid after the first correct answer
            }

            //if the image of the current picturebox is the second clue
            //and not a tilde or a hint, this function prints the messageBox
            else if (analyzer.CluesFound == 2)
            {
                
                MessageBox.Show("I will get you next time.", "Good Job, you found all the clues", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                GuessGrid.Visible = false;//does not allow any more guesses because the user found them all
                GiveUp.Enabled = false;//does not allow give up option because user found both clues
                Restart.Text = "Play Again?";
            }
        }

        //this function resets the grid after the first clue was found
        public void ResetGrid()
        {
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                {
                    //if its not the first clue, change the image back to a tilde
                    if (grid[i, j].Image != aClue)
                    {
                        grid[i, j].Image = Properties.Resources.tilde;
                    }
                }
        }

        //button to give up and display answers
        private void GiveUp_Click(object sender, EventArgs e)
        {
            //sets coordinates in an array for rows and columns
            int[] x = new int[] { analyzer.Clues[0].RowCoordinates, analyzer.Clues[1].RowCoordinates };
            int[] y = new int[] { analyzer.Clues[0].ColumnCoordinates, analyzer.Clues[1].ColumnCoordinates };
            
            //gets the image for the pictureboxes from the checkifclue function
            grid[x[0], y[0]].Image = analyzer.CheckIfClue(x[0], y[0]);
            grid[x[1], y[1]].Image = analyzer.CheckIfClue(x[1], y[1]);

            //tells the user they have a punishment for not finding the clues
            MessageBox.Show("Time for your punishment.", "You failed the test", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            ClueDecision.Visible = false;

            //initalizes the music and background for the punishment
            punishment = new SoundPlayer("PopUp.wav");
            punishment.Play();
            StartBackground.Image = haha;

            Restart.Text = "Play Again?";
            Restart.Visible = false;
        }

        //the function changes anything that was different from the start screen 
        //back to how the start screen looked
        private void Restart_Click(object sender, EventArgs e)
        {
            //removes the pictureboxes one by one
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    ClueDecision.Controls.Remove(grid[i, j]);
                }
            }

            //these controls are self explanatory but are all needed to revert any changes back to the start screen
            RowEntry.Visible = false;
            RowEntry.Enabled = true;
            RowEntry.Text = "Enter the Row Size:";
            ColumnEntry.Visible = false;
            ColumnEntry.Enabled = true;
            ColumnEntry.Text = "Enter the Column Size:";

            GenerateGrid.Visible = false;
            GenerateGrid.Enabled = true;

            RowGuess.Visible = false;
            RowGuess.Text = "Enter your Row Guess:";
            ColumnGuess.Visible = false;
            ColumnGuess.Text = "Enter your Column Guess:";

            Stats.Visible = false;
            ClueDecision.Text = "What kind of Clue do whish to discover?";
            Restart.Text = "Restart";
            
            Fing.Enabled = true;
            BloodS.Enabled = true;
            Related.Enabled = true;
            Hair.Enabled = true;

            GuessGrid.Visible = false;
            GiveUp.Enabled = true;
            GiveUp.Visible = false;
            ClueDecision.Visible = true;
            StartBackground.Image = bth;
        }

        PictureBox[,] grid;//creates a 2D array and calls it grid
        Analyzer analyzer;//intializes an analyzer

        //row & col - grid dimensions that the user sets
        //rowG & colG - grid points of the users guess
        //i & j- indices for the grid you display
        int row, col, rowG, colG, i, j, NumberOfGuesses;

        bool FirstClueNotFound;

        private SoundPlayer intro;//provides saw sound to the form
        private SoundPlayer gameAudio;//plays track for the game
        private SoundPlayer punishment;//punishment for giving up on the game

        private int radioValue;
        Image haha = Properties.Resources.goat;
        Image bth = Properties.Resources.bathroom;//creepy bathroom background
        Image saw = Properties.Resources.Saw;//blank saw background
        Image aClue;//image that is a clue
    }
}
