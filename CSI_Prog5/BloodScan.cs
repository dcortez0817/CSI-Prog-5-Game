using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace CSI_Prog5
{
    class BloodScanner : Analyzer
    {
        public BloodScanner(int r, int c) : base(r, c)
        {

        }
        public override Image CheckIfClue(int rowGuess, int columnGuess)
        {
            //Set New Player Position [0] for row [1] for column
            PlayerPos[0] = rowGuess;
            PlayerPos[1] = columnGuess;
            for (int i = 0; i < _NumOf; i++)
            {
                if ((Clues[i].Rowcoordinates == rowGuess) && (Clues[i].ColumnCoordinates == columnGuess))
                {
                    Clues.RemoveAt(i);
                    return Clues[i].Img;
                }
            }
            Image ret = GetHint();
            return ret;

            
        }
        public override void Generate2Clues()
        {
            for (int i = 0; i < _NumOf; i++)
            {
                //Generates random seed better than using time
                RandomGenerator = new Random(Guid.NewGuid().GetHashCode());
                Clues[i].Rowcoordinates = RandomGenerator.Next(0, TotalRows);
                Clues[i].ColumnCoordinates = RandomGenerator.Next(0, TotalColumns);

                //COME BACK AND SET TO FINGERPRINT JPG AFTER ADDING TO RESOURCES
                Clues[i].Img = null;
            }
        }
        public override Image GetHint()
        {
            if (PlayerPos[0] == Clues[0].Rowcoordinates)
            {
                return PlayerPos[0] < Clues[0].Rowcoordinates ? Properties.Resources.lessThan : Properties.Resources.Greaterthan;
            }
            else
            {
                return PlayerPos[1] < Clues[0].ColumnCoordinates ? Properties.Resources.Up : Properties.Resources.down;
            }
        }
    }
}
