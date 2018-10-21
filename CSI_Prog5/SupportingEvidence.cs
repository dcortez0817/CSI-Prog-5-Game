using System.Drawing;
using System.Windows.Forms;

namespace CSI_Prog5
{
    class SupportingEvidence : Finger
    {
        public  SupportingEvidence(short r, short c) : base(r,c)
        {
            //Generates the same amount of supporting
            //evidence as finger prints
            for (int i = 0; i < NumClues; i++)
                Randomize(i);
        }

        //checks if the clue is found
        public override void CheckIfClue()
        {
            NumGuesses++;
            //random image index for supporting evidence
            Inum = Rand.Next(0, 7);

            //if guess is correct do the following
            if (RCoord[ClueNum] == XPos && CCoord[ClueNum] == YPos)
            {
                Array[Rows, Columns].IsClue = true;
                ResetGrid();
                Array[Rows, Columns].Img = evidence[Inum];//random supporting evidence image
                MessageBox.Show("You discovered " + evidenceMes[Inum], "Not Bad.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        //any position not showing a form of supporting evidence changes to empty
        public override void ResetGrid()
        {
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Columns; j++)
                {
                    if (Array[i, j].Img != evidence[Inum])
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

        //random image index for supporting evidence
        private int Inum;

        //stores supporting evidence pictures in an array
        private readonly Image[] evidence = { Properties.Resources.isis_flag,
        Properties.Resources.bong, Properties.Resources.marijuana,
        Properties.Resources.dna, Properties.Resources.gun,
        Properties.Resources.KKK, Properties.Resources.leadPipe,
        Properties.Resources.Google};

        //generates a message based on the evidence discovery
        private readonly string[] evidenceMes ={ "ISIS Ties",
                                              "drug paraphernalia",
                                              "drugs",
                                              "some form of DNA",
                                              "a gun",
                                              "a KKK Pamphlet",
                                              "a lead pipe",
                                              "a suspicious Google search"
                                            };

        
    }

    
}
