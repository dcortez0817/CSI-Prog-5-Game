using System;
using System.Drawing;
using System.Windows.Forms;

namespace CSI_Prog5
{

    class SupportingEvidence : Analyzer
    {
        //SupportingEvidence()
        //Paramets: int r and int c
        //Returns: na
        //Description: Calls base class and established side of matrice
        //             Generates 2 clues in the list Clues.
        public SupportingEvidence(int r, int c) : base(r, c)
        {
            TotalColumns = c;
            TotalRows = r;
            Generate2Clues();

        }

        //override CheckIfClue()
        //Parameters: int rowGuess and columnGuess representing the row and column guess of the user
        //Return: Bool(true if found, false if not found)
        public override Image CheckIfClue(int row, int col)
        {
            Image ret;
            //Set New Player Position [0] for row [1] for column
            PlayerPos[0] = row;
            PlayerPos[1] = col;
            for (int i = 0; i < Clues.Count; i++)
            {
                if ((Clues[i].RowCoordinates == row) && (Clues[i].ColumnCoordinates == col))
                {
                    CluesFound++;
                    ret = Clues[i].Img;
                    Clues.RemoveAt(i);
                    return ret;
                }
            }
            ret = GetHint();
            return ret;
        }
        //Generate2Clues()
        //Parameters: None
        //Returns: None
        //Description: The method creates 2 clue objects and pushes them to the list Clues, belonging
        //             to the base class.
        public override void Generate2Clues()
        {
            for (int i = 0; i < _NumOf; i++)
            {
                //Generates random seed better than using time
                RandomGenerator = new Random(Guid.NewGuid().GetHashCode());
                Clues.Add(new ClueInfo()
                {
                    RowCoordinates = RandomGenerator.Next(0, TotalRows-1),
                    ColumnCoordinates = RandomGenerator.Next(0, TotalColumns-1),
                    Img = SupportEvidence[RandomGenerator.Next(0, 7)]
                });
            }
        }

        //override GetHint()
        //Parameters: none
        //Return: none
        //Description: The method returns a photo corresponding to a hint of the first
        //             clue residing at clues[0]
        public override Image GetHint()
        {
            if (PlayerPos[0] == Clues[0].RowCoordinates)
            {
                return Clues[0].ColumnCoordinates < PlayerPos[1] ? Properties.Resources.Less_Than : Properties.Resources.Greater_than;
            }
            else
            {
                return Clues[0].RowCoordinates < PlayerPos[0] ? Properties.Resources.Up : Properties.Resources.down;
            }
        }
    }


}
