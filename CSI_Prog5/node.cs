namespace CSIGame
{
    class Node
    {
        private char character;
        private bool beenChecked;
        private bool isClue;
        private bool beenFound;
        private string clueType;
        //node
        public Node()
        {
            character = '~';
            beenChecked = false;
            isClue = false;
            beenFound = false;
            clueType = "";


        }

        public char Character { get => character; set => character = value; }
        public bool BeenChecked { get => beenChecked; set => beenChecked = value; }
        public bool IsClue { get => isClue; set => isClue = value; }
        public bool BeenFound { get => beenFound; set => beenFound = value; }
        public string ClueType { get => clueType; set => clueType = value; }
    }
}
