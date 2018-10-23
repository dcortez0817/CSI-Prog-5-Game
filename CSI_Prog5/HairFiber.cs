using System;
using System.Drawing;

namespace CSI_Prog5
{
    abstract class HairFiberScan : Analyzer
    {
        public HairFiberScan(int r, int c) : base(r,c)
        {
            
        }
        public override void Generate2Clues(){
              for (int i = 0; i < _NumOf; i++)
            {
                //Generates random seed better than using time
                RandomGenerator = new Random(Guid.NewGuid().GetHashCode());
                Clues[i].RowCoordinates = RandomGenerator.Next(0, TotalRows);
                Clues[i].ColumnCoordinates = RandomGenerator.Next(0, TotalColumns);

                //COME BACK AND SET TO FINGERPRINT JPG AFTER ADDING TO RESOURCES
                Clues[i].Img = null;
            }
        }
        public override Image CheckIfClue(int rowGuess, int colGuess){
            //Set New Player Position [0] for row [1] for column
            PlayerPos[0] = rowGuess;
            PlayerPos[1] = colGuess;
            for (int i = 0; i < _NumOf; i++)
            {
                if ((Clues[i].RowCoordinates == rowGuess) && (Clues[i].ColumnCoordinates == colGuess))
                {
                    Clues.RemoveAt(i);
                    return Clues[i].Img;
                }
            }
            Image ret = GetHint();
            return ret;

        }
        public override Image GetHint(){
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