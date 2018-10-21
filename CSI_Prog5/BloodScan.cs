using System;

namespace testingGrounds
{
    //Class : Finger (inherits from Analyzer)
    //Class Members: All inherited from Analyzer Class
    //               const string V
    //Methods:override Randomize()
    //        override CheckIfClue()
    //        override ToString()
    //        Inherited constructors from base class
    class Finger : Analyzer
    {
        public Finger(short rows, short columns) : base(rows, columns)
        { 
            Rand = new Random(Guid.NewGuid().GetHashCode());
            for (int i = 0; i < NumClues; i++)
                Randomize(i);
        }

        //override Randomizer()
        //Parameters:none
        //Return:void
        //Description: Creates random instances of clues on the 
        //             matrix, sets clue type to Fingerprint
        public override void Randomize(int i)
        {
            int x,
                y;

            Rand = new Random(Guid.NewGuid().GetHashCode());
            x = Rand.Next(1, Rows);
            Rand = new Random(Guid.NewGuid().GetHashCode());
            y = Rand.Next(1, Columns);
            Array[x, y].ClueType = V;
            Array[x, y].IsClue = true;
            base.RCoord[i] = x;
            base.CCoord[i] = y;


        }
        //override CheckIfClue
        //Parameters: short c and short r
        //Return: bool
        //Description: Checks if a clue resides in the matrix 
        //             at Array[r,c]. The element is mark as 
        //             checked always.Returns true or false
        //             if element is a clue
        public override bool CheckIfClue(short c, short r)
        {
            NumGuesses++;
            XPos = r;
            YPos = c;
            Array[r, c].BeenChecked = true;
            if (Array[r, c].ClueType == V)
            {
                RCoord.RemoveAt(0);
                CCoord.RemoveAt(0);
                Array[r, c].BeenFound = true;
                Array[r, c].Character = '@';
                NumGuesses++;
                return true;
            }
           
            return false;
        }

        //override ToString()
        //Parameters: none
        //Return: string
        //Description: Returns a string contiaining 
        public override string ToString()
        {
            string ret = "";
            for (int r = 0; r < Rows; r++)
            {
                for (int c = 0; c < Columns; c++)
                {
                    ret += Array[r, c].Character.ToString();
                    ret += " ";
                }

            }
            return ret;
        }
     

       
    }
}
