using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testingGrounds
{
    abstract class Analyzer
    {
        //Analyzer()
        //Parameters: short rows, short columns
        //Return: NA
        //Description:instantiates class objects and sets dimensions
        //            of 2d array
        protected Analyzer(short rows, short columns)
        {
            this.rows = rows;
            this.columns = columns;
            array = new Node[rows, columns];
            xPos = yPos = 0;
            Initialize();
            numGuesses = 0;
            
            rCoord = new List<int>();
            cCoord = new List<int>();
            Initialize();
            
        }

        //Initialize()
        //Parameters: none
        //Return: none
        //Description: Instantiates all member of 2d array to type Node
        public void Initialize()
        {
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    array[i, j] = new Node();
        }

        // GetHint()
        //Parameters:: None
        //Return : char
        //Description: Returns a hint based upon player position on 
        //             the board
        public char GetHint()
        {
            char hint;
            //if on the same row, point left or right
            if (XPos == RCoord.First())
            {
                hint = (CCoord.First() < YPos) ? '>' : '<';
            }
            else
            {
                hint = (RCoord.First() < XPos) ? '^' : 'V';
            }
            return hint;
        }
        public abstract void Randomize(int i);
        public abstract bool CheckIfClue(short c, short r);
      
        //Array of Clues representing 1 2d array of possible clues
        private Node[,] array;
        public Node[,] Array { set=>array=value; get=>array; }

        //represent rows in the 2d array
        private int rows;
        public int Rows { get=>rows; set=>rows=value; }

        //represents number of columns in 2d array
        private int columns;
        public int Columns { get=>columns; set=>columns=value; }

        //Represent players current x coordinate
        private int xPos;
        public int XPos { get => xPos; set => xPos = value; }

        //Represents players current y coordinate
        private int yPos;
        public int YPos { get => yPos; set => yPos = value; }

        //Random generator used to create random numbers
        public Random Rand { get => rand; set => rand = value; }
        private Random rand;

        //constant clues per instance to find
        private static int numClues = 2;
        public static int NumClues { get => numClues; set => numClues = value; }

        //Number of guesses by player
        private int numGuesses;
        public int NumGuesses { get; set; }

        //Used to store clues locations
        //
        private List<int> rCoord;
        private List<int> cCoord;
        public List<int> RCoord { get; set; }
        public List<int> CCoord { get; set; }
       

        public const string V = "FingerPrint";



    }
}
