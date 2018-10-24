using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace CSI_Prog5
{
    //Class: Analyzer()
    //Methods: Analyzer(int,int) (Parameterized Constructor)
    //         abstract void Generate2Clues()
    //         abstract Image CheckIfClue(int,int)
    //Members: int numberOfGuesses
    //         int[] playerPos
    //         string[] supportingEvidence
    //         int totalRows
    //         int totalColumns
    //         List<ClueInfor> Clues
    //         Random RandomGenerator

    abstract class Analyzer
    {

        //Analyzer()
        //Parameters: int Rows int Columns
        //Returns: na
        //Description: Parameterized constructor sets totalRow and totalColumns.
        //             Representing the max indexs of a game matrice. List of clues 
        //             is initialized to store clueinfo for game use. 
        public Analyzer(int Rows, int Columns)
        {
            //Initialize list to hold clueinfo for each clue
            clues = new List<ClueInfo>();
            CluesFound = 0;

            playerPos = new int[_NumOf];
        }

        public abstract void Generate2Clues();
        public abstract Image CheckIfClue(int row, int col);
        public abstract Image GetHint();
        public int CluesFound { get; set; }

        //playerPos[0] holds the players row position on the board
        //playerPos[1] hold the players column position on the board
        private int[] playerPos;
        public int[] PlayerPos
        {
            get { return playerPos; }
            set { playerPos = value; }
        }

        //Array of Images used in supportevidence clues
        private readonly Image[] supportEvidence ={ Properties.Resources.isis_flag,
                                                   Properties.Resources.bong,
                                                   Properties.Resources.marijuana,
                                                   Properties.Resources.dna,
                                                   Properties.Resources.gun,
                                                   Properties.Resources.KKK,
                                                   Properties.Resources.leadPipe,
                                                   Properties.Resources.Google
                                                   };
        public Image[] SupportEvidence => supportEvidence;

        //Used for clue placement and matrice construction
        private int totalRows;
        public int TotalRows { get; set; }

        //Used for clue placement and matrice construction
        private int totalColumns;
        public int TotalColumns { get; set; }

        //Holds a list of generated clues allowing the game board to easily check
        //if a player has guessed correctly
        private List<ClueInfo> clues;
        public List<ClueInfo> Clues { get { return clues; } set { clues = value; } }

        //Random generator for pseudo random placements
        private Random randomGenerator;
        public Random RandomGenerator { get; set; }

        public const int _NumOf = 2;
    }
}
