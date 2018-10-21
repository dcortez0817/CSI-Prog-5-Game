using System;

namespace CSIGame
{
    class SupportingEvidence : Finger
    {
        public SupportingEvidence(short r, short c) : base(r, c)
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
        }
        public override bool CheckIfClue(short r, short c)
        {
            Array[r, c].BeenChecked = true;
            if (Array[r, c].IsClue == true)
            {
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
