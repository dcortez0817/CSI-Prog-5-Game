using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSI_Prog5
{
    class SupportingEvidence : Finger
    {
        //SupportingEvidence
        public  SupportingEvidence(short r, short c) : base(r,c)
        {
            for (int i = 0; i < NumClues; i++)
                Randomize(i);
        }
        public override void Randomize(int i)
        {
            int x,
                y,
                clueIndex;
            //Creat random X position
            Rand = new Random(Guid.NewGuid().GetHashCode());
            x = Rand.Next(1, Rows);

            //Creat random Y position
            Rand = new Random(Guid.NewGuid().GetHashCode());
            y = Rand.Next(1, Columns);

            //Create Random Clue to seed
            Rand = new Random(Guid.NewGuid().GetHashCode());
            clueIndex = Rand.Next(0, evidence.Length);
            Array[x, y].ClueType = evidence[clueIndex];
            Array[x, y].IsClue = true;

            //Store clue location in list
            RCoord[i] = x;
            CCoord[i] = y;

        }
        public override bool CheckIfClue(short c, short r)
        {
            NumGuesses++;
            this.XPos = r;
            this.YPos = c;
            Array[r, c].BeenChecked = true;
            if (Array[r, c].IsClue == true)
            {
                RCoord.RemoveAt(0);
                CCoord.RemoveAt(0);
                Array[r, c].BeenFound = true;
                return true;
            }
            return false;
        }
        private readonly string[] evidence ={ "ISIS Ties",
                                              "Drug Paraphernalia",
                                              "Drugs",
                                              "Knife",
                                              "Gun",
                                              "KKK Pamphlet",
                                              "Lead Pipe",
                                              "Suspicious Google Search"
                                            };
    }
}
