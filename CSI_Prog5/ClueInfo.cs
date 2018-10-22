using System;
using System.Drawing;
namespace CSI_Prog5
{
    class ClueInfo
    {
        public ClueInfo{
            int rowCoordinates = 0;
            int columnCoordinates = 0;
            int img = Properties.Resources.tilde;
        }
        private int rowCoordinates;
        public int RorCoordinates{get;set;}
        private int columnCoordinates;
        public int ColumnCoordinates{get;set;}
        private Image img;
        public Image Img{get;set;}
    }
}
