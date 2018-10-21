using System;
using System.Windows.Forms;

namespace CSI_Prog5
{
    //Class : Finger (inherits from Analyzer)
    //Class Members: All inherited from Analyzer Class
    //               const string V
    //Methods:override Randomize()
    //        override CheckIfClue()
    //        override ToString()
    //        Inherited constructors from base class
    class Finger : Analyzer
    {
        public Finger(short rows, short columns) : base(rows, columns)
        {
            //Generates up to 3 Finger Prints
            Rand = new Random(Guid.NewGuid().GetHashCode());
            NumClues = Rand.Next(1, 3);

            for (int i = 0; i < NumClues; i++)
                Randomize(i);
        }

        public void getguess(int rguess, int cguess)
        {
            XPos = (short)rguess;
            YPos = (short)cguess;
        }

        //checks if the clue is found
        public override void CheckIfClue()
        {
            NumGuesses++;

            //if guess is correct do the following
            if (RCoord[ClueNum] == XPos && CCoord[ClueNum] == YPos)
            {
                Array[Rows, Columns].IsClue = true;
                ResetGrid();
                Array[Rows, Columns].Character = 'X';
                MessageBox.Show("You discovered fingerprints from something.", "Impressive.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ClueNum++;
            }

            else
                Array[Rows, Columns].Character = Hint();
        }

        //TextBox Grid version to return a string hint
        private char Hint()
        {
            char c;
            //uses ternary operator to see if guess is above or below the sample
            if (NumGuesses % 2 == 0)
                c = XPos > RCoord[ClueNum] ? '^' : 'v';

            //uses ternary operator to see if guess is to the left or to the right of the sample
            else
                c = YPos > CCoord[ClueNum] ? '<' : '>';

            return c;
        }

        //any position not showing an @ symbol changes to empty
        public override void ResetGrid()
        {
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Columns; j++)
                {
                    if (Array[i, j].Character != '@')
                    {
                        Array[i, j].Character = (char)0;//fills with NULL
                    }
                }
        }

        public override void GaveUp()
        {
            for (int i = 0; i < NumClues; i++)
                Array[RCoord[i], CCoord[i]].Character = 'X';

            ResetGrid();
        }
    }
}
