using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace CSI_Prog5
{
    class FPScanner : Analyzer
    {
        //FPScanner()
        //Parameters: int row and column, representing the total size of the scanner array
        //Returns:None
        //Description: intializes the base class to size r x c
        public FPScanner(int r, int c) : base(r, c)
        {
            TotalRows = r;
            TotalColumns = c;
            Generate2Clues();
        }

        //override CheckIfClue()
        //Parameters: int rowGuess and columnGuess representing the row and column guess of the user
        //Return: Bool(true if found, false if not found)
        public override Image CheckIfClue(int rowGuess, int columnGuess)
        {
            //Set New Player Position [0] for row [1] for column
            PlayerPos[0] = rowGuess;
            PlayerPos[1] = columnGuess;
            for (int i = 0; i < _NumOf; i++)
            {
                if ((Clues[i].RowCoordinates == rowGuess) && (Clues[i].ColumnCoordinates == columnGuess))
                {
                    Clues.RemoveAt(i);
                    return Clues[i].Img;
                }
            }
            Image ret = GetHint();
            return ret;
        }

        //override Generate2Clues()
        //Parameters: none
        //Return: void
        //Description: The method creates 2 random clues and stores the information in the List<ClueInfo> cluesOf
        //             A fingerprint photo is inserted in the clue. 
        public override void Generate2Clues()
        {
            for (int i = 0; i < _NumOf; i++)
            {
                //Generates random seed better than using time
                RandomGenerator = new Random(Guid.NewGuid().GetHashCode());
                Clues.Add(new ClueInfo() { RowCoordinates = RandomGenerator.Next(0, TotalRows),
                                           ColumnCoordinates = RandomGenerator.Next(0, TotalColumns),
                                           Img = Properties.Resources.fingerPrint} );
                //Clues[i].Add(new ClueInfo() { })
                //Clues[i].RowCoordinates = RandomGenerator.Next(0, TotalRows);
                //Clues[i].ColumnCoordinates = RandomGenerator.Next(0, TotalColumns);

                ////COME BACK AND SET TO FINGERPRINT JPG AFTER ADDING TO RESOURCES
                //Clues[i].Img = Properties.Resources.fingerPrint;
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
                return PlayerPos[0] < Clues[0].RowCoordinates ? Properties.Resources.Less_Than : Properties.Resources.Greater_than;
            }
            else
            {
                return PlayerPos[1] < Clues[0].ColumnCoordinates ? Properties.Resources.Up : Properties.Resources.down;
            }
        }


    }
}
