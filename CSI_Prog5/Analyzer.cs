using System;
using System.Drawing;

namespace CSI_Prog5
{
   
    abstract class Analyzer
    {
       
        //Constructor
        //Parameters: 2 shorts, rows and columns, represent rows and 
        //            columns of the analyzer matrix for storing clues
        //return: na
        //Description:Establishes a 2d or size rows and columns, the players
        //            positions is set on the board instantiating Xpos and Ypos
        protected Analyzer(short rows, short columns)
        {
            this.rows = rows;
            this.columns = columns;
            RCoord = new int[2];
            CCoord = new int[2];
            array = new Node[rows, columns];
            xPos = yPos = 0;
            cNum = 0; //clue number
            Guesses = 0;
            Initialize();
        }
        //Initialize
        //Parameters: none
        //Return: None
        //Descirption: Initializes elements of 2d array 
        public void Initialize()
        {
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    array[i, j] = new Node();
        }

        //Randomize
        //Returns: none
        //Parameters: none
        //Description: public class to randomly find values for
        //             the number of rows and columns of the grid.
        //             'n' represents the number of clues placed on
        //             the grid.
        public void Randomize(int n)
        {
            for (int i = 0; i < n; i++)
                RCoord[i] = Rand.Next(0, Rows);//rows of clues

            for (int i = 0; i < n; i++)
                CCoord[i] = Rand.Next(0, Columns);//columns of clues
        }

        //CheckIfClue
        //Parameters: none
        //Return: none
        //Description: Abstract class to be overridden in child classes
        //             Used to determine if a clue is residing on the matrix
        //             at a given element
        public abstract void CheckIfClue();

        //ResetGrid
        //Parameters: none
        //Return: none
        //Description: Abstract class to be overridden in child classes
        //             Used to reset textbox grid and visual grids
        public abstract void ResetGrid();

        //GaveUp
        //Parameters: none
        //Return: none
        //Description: Abstract class to be overridden in child classes
        //             shows answer when user gives up
        public abstract void GaveUp();
        
        //keeps track of the clue count
        private short cNum;
        public short ClueNum { get => cNum; set => rows = value; }
        //number of user guesses
        private short Guesses;
        public short NumGuesses { get => Guesses; set => rows = value; }
        //holds random coordinate for rows
        public int[] RCoord;
        //holds random coordinate for columns
        public int[] CCoord;
        //2d array of nodes representing game play
        private Node[,] array;
        public Node[,] Array { set => array = value; get => array; }
        //Represent row of 2d matrix
        private short rows;
        public short Rows { get => rows; set => rows = value; }
        //represents number of columns in matrix
        private short columns;
        public short Columns { get => columns; set => columns = value; }
        //Stores the x coordinate of where the player is on the board
        private short xPos;
        public short XPos { get => xPos; set => xPos = value; }
        //Stores the Y coordinate of the players current position
        private short yPos;
        public short YPos { get => yPos; set => yPos = value; }
        //used to generate random numbers for clues
        public Random Rand { get => rand; set => rand = value; }
        private Random rand;
        //Stores the number of clues in the array
        private int numClues;
        public int NumClues { get => numClues; set => numClues = value; }
    }
}