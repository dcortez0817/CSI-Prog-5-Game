using System;
using System.Drawing;
namespace CSI_Prog5
{
    public class ClueInfo
    {
        public ClueInfo(){
            int rowCoordinates = 0;
            int columnCoordinates = 0;
            img = Properties.Resources.tilde;
        }
        private int rowCoordinates;
        public int RowCoordinates{get;set;}
        private int columnCoordinates;
        public int ColumnCoordinates{get;set;}
        private Image img;
        public Image Img{get;set;}
    }
}
