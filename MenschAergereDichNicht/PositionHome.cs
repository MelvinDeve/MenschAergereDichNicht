using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        Pos GetCoord(int pos, int col)
        {
            switch (col)
            {
                case 0:
                    return positions_home_blue[pos];
                case 1:             
                    return positions_home_red[pos];
                case 2:             
                    return positions_home_yellow[pos];
                case 3:             
                    return positions_home_green[pos];
                default:            
                    return positions_home_green[0];
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
