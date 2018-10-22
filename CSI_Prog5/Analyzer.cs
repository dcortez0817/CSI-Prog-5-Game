using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace CSI_Prog5
{
    abstract class Analyzer
    {
        public Analyzer(int totalRows, int totalColumns)
        {
            //Set Total Columns and Rows for scanalyzer
            this.totalRows = totalRows;
            this.totalColumns = totalColumns;

            //Initialize list to hold clueinfo for each clue
            var clues = new List<ClueInfo>();
            numberOfGuesses = 0;

            playerPos = new int[_NumOf];
        }
     
        public abstract void Generate2Clues();
        public abstract Image CheckIfClue(int row, int column);
        public abstract Image GetHint();

        //Array of Images used in supportevidence clues
        private readonly Image[] supportEvidence ={ Properties.Resources.isisFlag,
                                                   Properties.Resources.bong,
                                                   Properties.Resources.marijuana,
                                                   Properties.Resources.dna,
                                                   Properties.Resources.gun,
                                                   Properties.Resources.KKK,
                                                   Properties.Resources.leadPipe,
                                                   Properties.Resources.Google
                                                   };
        private int numberOfGuesses;
        public int NumberOfGuesses { get; set; }

        private int[] playerPos;
        public int[] PlayerPos { get; set; }


        private int totalRows;
        public int TotalRows { get; set; }

        private int totalColumns;
        public int TotalColumns { get; set; }

        private List<ClueInfo> clues;
        public List<ClueInfo> Clues { get; set; }

        private Random randomGenerator;
        public Random RandomGenerator { get; set; }

        public Image[] SupportEvidence => supportEvidence;

        public readonly int _NumOf = 2;
    }
}
