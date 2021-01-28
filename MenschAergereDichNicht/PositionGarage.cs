using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MenschAergereDichNicht
{
    class PositionGarage
    {
        Pos[] positions_garage_blue = new Pos[4];
        Pos[] positions_garage_red = new Pos[4];
        Pos[] positions_garage_yellow = new Pos[4];
        Pos[] positions_garage_green = new Pos[4];
        Pos defaultPosition = new Pos(0, 0);

        

        Pos GetGarageCoord(int pos, int col)
        {
            switch (col)
            {
                case 0:
                    return positions_garage_blue[pos];
                case 1:              
                    return positions_garage_red[pos];
                case 2:              
                    return positions_garage_yellow[pos];
                case 3:              
                    return positions_garage_green[pos];
                default:             
                    return defaultPosition;
            }

        }
        /// <summary>
        /// returns the number of immoveable figures 
        /// </summary>
        /// <param name="figures"></param>
        /// <returns></returns>
        public int numberImmoveable(Figure[] figures)
        {
        int finalPos = 43;
        int count = 0;
            for(int i = 0; i < 4; i++)
            {
                if (figures[i].relPos == (finalPos + figures[i].diff))
                {
                    count++;
                    finalPos--;
                    i = 0;
                }
            }
            return count;
        }

        void fillGaragePositions()
        {
            positions_garage_blue[0] = new Pos(PosConst.xPos_5, PosConst.yPos_1);
            positions_garage_blue[1] = new Pos(PosConst.xPos_5, PosConst.yPos_2);
            positions_garage_blue[2] = new Pos(PosConst.xPos_5, PosConst.yPos_3);
            positions_garage_blue[3] = new Pos(PosConst.xPos_5, PosConst.yPos_4);

            positions_garage_red[0] = new Pos(PosConst.xPos_9, PosConst.yPos_5);
            positions_garage_red[1] = new Pos(PosConst.xPos_8, PosConst.yPos_5);
            positions_garage_red[2] = new Pos(PosConst.xPos_7, PosConst.yPos_5);
            positions_garage_red[3] = new Pos(PosConst.xPos_6, PosConst.yPos_5);

            positions_garage_yellow[0] = new Pos(PosConst.xPos_5, PosConst.yPos_9);
            positions_garage_yellow[1] = new Pos(PosConst.xPos_5, PosConst.yPos_8);
            positions_garage_yellow[2] = new Pos(PosConst.xPos_5, PosConst.yPos_7);
            positions_garage_yellow[3] = new Pos(PosConst.xPos_5, PosConst.yPos_6);

            positions_garage_green[0] = new Pos(PosConst.xPos_1, PosConst.yPos_5);
            positions_garage_green[1] = new Pos(PosConst.xPos_2, PosConst.yPos_5);
            positions_garage_green[2] = new Pos(PosConst.xPos_3, PosConst.yPos_5);
            positions_garage_green[3] = new Pos(PosConst.xPos_4, PosConst.yPos_5);

        }
    }
}
