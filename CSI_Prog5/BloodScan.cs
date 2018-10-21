using System;
using System.Drawing;
using System.Windows.Forms;

namespace CSI_Prog5

{
    class BloodScan : Analyzer
    {
        public BloodScan(short row, short col) :base(row, col)
        {
            //Generate up to 3 Blood traces
            Rand = new Random(Guid.NewGuid().GetHashCode());
            NumClues = Rand.Next(1, 3);
         
            for (int i = 0; i < NumClues; i++)
                Randomize(i);
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
                Array[Rows, Columns].Img = Properties.Resources.bloody_hand;//blood image
                MessageBox.Show("You discovered blood EVERYWHERE...\nliterally everywhere.", "Nice.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ClueNum++;
            }

            else
                Array[Rows, Columns].Img = IHint();
        }

        //visually changes grid
        private Image IHint()
        {
            Image sign;
            //uses ternary operator to see if guess is above or below the sample
            if (NumGuesses % 2 == 0)
                sign = XPos > RCoord[ClueNum] ? Properties.Resources.Up : Properties.Resources.down;

            //uses ternary operator to see if guess is to the left or to the right of the sample
            else
                sign = YPos > CCoord[ClueNum] ? Properties.Resources.Less_Than : Properties.Resources.Greater_than;

            return sign;
        }

        //any position not showing a bloody hand changes to empty
        public override void ResetGrid()
        {
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Columns; j++)
                {
                    if (Array[i, j].Img != Properties.Resources.bloody_hand)
                    {
                        Array[i, j].Img = null;
                    }
                }
        }

        public override void GaveUp()
        {
            for (int i = 0; i < NumClues; i++)
                Array[RCoord[i], CCoord[i]].Img = Properties.Resources.bloody_hand;

            ResetGrid();
        }
    }
}