using System;
using System.Drawing;
using System.Windows.Forms;

namespace CSI_Prog5
{
    class SupportingEvidence : BloodScanner
    {
        public SupportingEvidence(int r, int c) : base(r, c)
        {
            // Get 2 types of supporting evidence clues using random
            //to assign supporting evidence photos
            RandomGenerator = new Random(Guid.NewGuid().GetHashCode());
            int firstPhoto = RandomGenerator.Next(0, 7);
            Clues[0].Img = SupportEvidence[firstPhoto];
            RandomGenerator = new Random(Guid.NewGuid().GetHashCode());
            int secondPhoto = RandomGenerator.Next(Guid.NewGuid().GetHashCode());
            Clues[1].Img = SupportEvidence[secondPhoto];
            
        }


        
    }

    
}
