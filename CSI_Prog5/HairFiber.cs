using System;
using System.Drawing;

namespace CSI_Prog5
{
    class HairFiberScan : Analyzer
    {
        public HairFiberScan(int r, int c) : base(r,c)
        {
            TotalRows = r;
            TotalColumns = c;
            Generate2Clues();
        }
        public override void Generate2Clues(){
              for (int i = 0; i < _NumOf; i++)
            {
                RandomGenerator = new Random(Guid.NewGuid().GetHashCode());
                Clues.Add(new ClueInfo()
                {
                    RowCoordinates = RandomGenerator.Next(1, TotalRows),
                    ColumnCoordinates = RandomGenerator.Next(1, TotalColumns),
                    Img = Properties.Resources.fingerPrint
                });
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
                return Clues[0].ColumnCoordinates < PlayerPos[1] ? Properties.Resources.Less_Than : Properties.Resources.Greater_than;
            }
            else
            {
                return Clues[0].RowCoordinates < PlayerPos[0] ? Properties.Resources.Up : Properties.Resources.down;
            }
        }
    }
}
