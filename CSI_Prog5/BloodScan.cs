using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIGame
{
    class BloodScan : Analyzer
    {
        public BloodScan(short row, short col) : base(row, col)
        {
            Rand = new Random(Guid.NewGuid().GetHashCode());

            //Generate up to 3 Blood traces
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
            Array[x, y].ClueType = type;

        }
        public override bool CheckIfClue(short c, short r)
        {
            this.XPos = r;
            this.YPos = c;
            Array[r, c].BeenChecked = true;
            if (Array[r, c].ClueType == type)
            {
                Array[r, c].BeenFound = true;
                return true;
            }
            return false;
        }
        private const string type = "BloodWork";
    }
}
