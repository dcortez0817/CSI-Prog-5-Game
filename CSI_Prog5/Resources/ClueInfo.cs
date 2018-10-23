using System;
using System.Drawing;
namespace CSI_Prog5
{
    public class ClueInfo
    {
        public ClueInfo(){
            int rowCoordinates;
            int columnCoordinates;
            img = Properties.Resources.tilde;
        }
        private int rowCoordinates;
        public int RowCoordinates{
            get { return rowCoordinates; }
            set { rowCoordinates = value; }
        }
        private int columnCoordinates;
        public int ColumnCoordinates{
            get { return columnCoordinates; }
            set { columnCoordinates = value; } }
        private Image img;
        public Image Img{ get { return img; } set { img = value; } }
    }
}
