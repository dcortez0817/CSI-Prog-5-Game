using System;
using System.Drawing;
namespace CSI_Prog5
{
    //Class BloodScanner
    //Members: BloodScanner(int,int) - parameterized constructor
    //         Generate2Clues()
    //         CheckIfClue(int,int) 
    //         GetHint()
    //Description:Scanner object that generate blood evidence, then allows users to guess 
    //            the location of it. Hints are returned in the form of Images.
    class BloodScanner : HairFiberScan
    {
        //BloodScanner()
        //Parameters: int r and int c, representing the total area to be used 
        //            in the base scanner object
        //Returns: None
        //Description: The method sets TotalColumns and TotalRows of the base class.
        //             Generate2Clues() is called to establish 2 bloody prints for th
        //             game.
        public BloodScanner(int r, int c) : base(r, c)
        {
            TotalColumns = r;
            TotalColumns = c;
            Generate2Clues();

        }

        //CheckIfClue()
        //Parameters: int rowGuess and int columnGuess, representing the users guess as 
        //            to where evidence is.
        //Returns:  Returns an Image, either of the bloody hand, or in the case of the 
        //          user guess being wrong. A hint is returned.
        public override Image CheckIfClue(int rowGuess, int columnGuess)
        {
            Image ret;
            //Set New Player Position [0] for row [1] for column
            PlayerPos[0] = rowGuess;
            PlayerPos[1] = columnGuess;
            for (int i = 0; i < _NumOf; i++)
            {
                if ((Clues[i].RowCoordinates == rowGuess) && (Clues[i].ColumnCoordinates == columnGuess))
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
                    Img = Properties.Resources.bloody_hand
                });



            }
        }

        //GetHint()
        //Parameters: None
        //Returns: Image, less than, greater than, up, or down.
        //Description: The method will return a hint to the user in the form
        //             of an image, suggesting to go left, right up or down.
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
