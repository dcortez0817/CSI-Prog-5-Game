using System;
using System.Drawing;

namespace CSI_Prog5
{
    //Class HairFiberScan
    //Members: HairFiberScan(int, int)
    //         Generate2Clues()
    //         CheckIfClue(int,int)
    //         GetHint()
    //         Inherited members from base class. See Analyzer.cs
    class HairFiberScan : Analyzer
    {
        //HairFiberScan()
        //Parameters: int r and c representing the total matrix size to consider
        //            for clue placement.
        //Returns: NA
        //Description: Method establishes size of matrix and generates 2 hair and fiber clues
        public HairFiberScan(int r, int c) : base(r, c)
        {
            TotalRows = r;
            TotalColumns = c;
            Generate2Clues();
        }

        //Generate2Clues()
        //Parameters: none
        //Returns: void
        //Description: Method generates 2 hair and fiber clues by creating a clue object,
        //             and adding it to the base member class List Clues.
        public override void Generate2Clues()
        {
            for (int i = 0; i < _NumOf; i++)
            {
                RandomGenerator = new Random(Guid.NewGuid().GetHashCode());
                Clues.Add(new ClueInfo()
                {
                    RowCoordinates = RandomGenerator.Next(0, TotalRows-1),
                    ColumnCoordinates = RandomGenerator.Next(0, TotalColumns-1),
                    Img = Properties.Resources.hair
                });
            }
        }

        //CheckIfClue()
        //Parameters: int rowGuess and int colGuess
        //Returns: Image of the clue, or a hint 
        //Description:
        public override Image CheckIfClue(int rowGuess, int colGuess)
        {
            //Set New Player Position [0] for row [1] for column
            Image ret;
            PlayerPos[0] = rowGuess;
            PlayerPos[1] = colGuess;
            for (int i = 0; i < _NumOf; i++)
            {
                if ((Clues[i].RowCoordinates == rowGuess) && (Clues[i].ColumnCoordinates == colGuess))
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

        //GetHint()
        //Parameters: None
        //Returns: Image, suggesting left right up or down
        //Description: This method points either left or right if the user is on the same row as 
        //             the clue, otherwise up or down, depending on the players position on the matrice
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
