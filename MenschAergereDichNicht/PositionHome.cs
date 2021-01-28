using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace MenschAergereDichNicht
{
    static class ColConst
    {
        public const int col_blue = 0;
        public const int col_red = 1;
        public const int col_yellow = 2;
        public const int col_green = 3;
        public static Brush getColorBrush(int color)
        {
            switch (color)
            {
                case ColConst.col_blue:
                    return Brushes.Blue;
                case ColConst.col_red:
                    return Brushes.DarkRed;
                case ColConst.col_yellow:
                    return Brushes.Gold;
                case ColConst.col_green:
                    return Brushes.Green;
                default:
                    return Brushes.Black;
            }
        }
    }

    
    class PositionHome
    {
        

        public Pos[] positions_home_blue = new Pos[4];
        public Pos[] positions_home_red = new Pos[4];
        public Pos[] positions_home_yellow = new Pos[4];
        public Pos[] positions_home_green = new Pos[4];
        public Pos defaultPosition = new Pos(0, 0);

        public Pos GetHomeCoord(int pinNum, int pos, int col)
        {
            switch (col)
            {
                case 0:
                    return positions_home_blue[pinNum];
                case 1:             
                    return positions_home_red[pinNum];
                case 2:             
                    return positions_home_yellow[pinNum];
                case 3:             
                    return positions_home_green[pinNum];
                default:            
                    return defaultPosition;
            }

        }
        /// <summary>
        /// Checks the Number of Pins which are still in Home 
        /// </summary>
        /// <param name="figures"></param>
        /// <returns></returns>
        public int numberInHouse(Figure[] figures)
        {
            int count = 0;
            foreach (Figure figure in figures)
            {
                if (figure.relPos < 0)
                {
                    count++;
                }
            }
            return count;
        }

        public PositionHome()
        {
            fillHomePositions();
        }

        

        void fillHomePositions()
        {
            positions_home_blue[0] = new Pos(PosConst.xPos_9, PosConst.yPos_0);
            positions_home_blue[1] = new Pos(PosConst.xPos_10, PosConst.yPos_0);
            positions_home_blue[2] = new Pos(PosConst.xPos_10, PosConst.yPos_1);
            positions_home_blue[3] = new Pos(PosConst.xPos_9, PosConst.yPos_1);

            positions_home_red[0] = new Pos(PosConst.xPos_9, PosConst.yPos_9);
            positions_home_red[1] = new Pos(PosConst.xPos_10, PosConst.yPos_9);
            positions_home_red[2] = new Pos(PosConst.xPos_10, PosConst.yPos_10);
            positions_home_red[3] = new Pos(PosConst.xPos_9, PosConst.yPos_10);

            positions_home_yellow[0] = new Pos(PosConst.xPos_0, PosConst.yPos_9);
            positions_home_yellow[1] = new Pos(PosConst.xPos_1, PosConst.yPos_9);
            positions_home_yellow[2] = new Pos(PosConst.xPos_1, PosConst.yPos_10);
            positions_home_yellow[3] = new Pos(PosConst.xPos_0, PosConst.yPos_10);

            positions_home_green[0] = new Pos(PosConst.xPos_0, PosConst.yPos_0);
            positions_home_green[1] = new Pos(PosConst.xPos_1, PosConst.yPos_0);
            positions_home_green[2] = new Pos(PosConst.xPos_1, PosConst.yPos_1);
            positions_home_green[3] = new Pos(PosConst.xPos_0, PosConst.yPos_1);

        }
    }
}
