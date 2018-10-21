using System.Drawing;
namespace CSI_Prog5
{
    class Node
    {
        private char character;
        private bool isClue;
        private bool beenFound;
        private Image img;
        //node
        public Node()
        {
            character = '~';
            isClue = false;
            beenFound = false;
            img = null;
        }

        public Image Img { get => img; set => img = value; }
        public char Character { get => character; set => character = value; }
        public bool IsClue { get => isClue; set => isClue = value; }
        public bool BeenFound { get => beenFound; set => beenFound = value; }
    }
}
