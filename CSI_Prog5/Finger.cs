using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIGame
{
    class Finger : Analyzer
    {
        public Finger(short rows, short columns) : base(rows, columns)
        {
            Rand = new Random(Guid.NewGuid().GetHashCode());

            //Generate up to 3 FingerPrint Clues per board
            NumClues = Rand.Next(1, 3);
            for (int i = 0; i < NumClues; i++)
                Randomize();
        }


        public override void Randomize()
        {
            int x,
                y;

            Rand = new Random(Guid.NewGuid().GetHashCode());
            x = Rand.Next(1, Rows);
            Rand = new Random(Guid.NewGuid().GetHashCode());
            y = Rand.Next(1, Columns);
            Array[x, y].ClueType = V;


        }
        public override bool CheckIfClue(short c, short r)
        {
            XPos = r;
            YPos = c;
            Array[r, c].BeenChecked = true;
            if (Array[r, c].ClueType == V)
            {
                Array[r, c].BeenFound = true;
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            string ret = "";
            for (int r = 0; r < Rows; r++)
            {
                for (int c = 0; c < Columns; c++)
                {
                    ret += Array[r, c].Character.ToString();
                }

            }
            return ret;
        }
        private const string V = "FingerPrint";
    }
}
