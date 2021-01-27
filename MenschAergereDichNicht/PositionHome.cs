using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MenschAergereDichNicht
{
    static class ColConst
    {
        public const int col_blue = 0;
        public const int col_red = 1;
        public const int col_yellow = 2;
        public const int col_green = 3;
    }
    class PositionHome
    {
        Pos[] positions_home_blue = new Pos[4];
        Pos[] positions_home_red = new Pos[4];
        Pos[] positions_home_yellow = new Pos[4];
        Pos[] positions_home_green = new Pos[4];
        Pos defaultPosition = new Pos(0, 0);

        Pos GetHomeCoord(int pinNum, int pos, int col)
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

        bool isinHome(Thickness thk, int color)
        {
            Pos tempPos = new Pos(thk.Left,thk.Top);
            switch (color)
            {
                case 0:
                    if (tempPos == positions_home_blue[0] || 
                        tempPos == positions_home_blue[1] || 
                        tempPos == positions_home_blue[2] || 
                        tempPos == positions_home_blue[3])
                    {
                        return true;
                    };
                    return false;
                case 1:
                    if (tempPos == positions_home_red[0] || 
                        tempPos == positions_home_red[1] || 
                        tempPos == positions_home_red[2] || 
                        tempPos == positions_home_red[3])
                    {
                        return true;
                    };
                    return false;
                case 2:
                    if (tempPos == positions_home_yellow[0] || 
                        tempPos == positions_home_yellow[1] || 
                        tempPos == positions_home_yellow[2] || 
                        tempPos == positions_home_yellow[3])
                    {
                        return true;
                    };
                    return false;
                case 3:
                    if (tempPos == positions_home_green[0] || 
                        tempPos == positions_home_green[1] || 
                        tempPos == positions_home_green[2] || 
                        tempPos == positions_home_green[3])
                    {
                        return true;
                    };
                    return false;
                default:
                    return false;
                        
            }
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
