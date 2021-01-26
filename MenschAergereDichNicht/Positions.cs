﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenschAergereDichNicht
{
    static class PosConst
    {
        public const int yPos_0 = -6;
        public const int yPos_1 = 30;
        public const int yPos_2 = 66;
        public const int yPos_3 = 102;
        public const int yPos_4 = 138;
        public const int yPos_5 = 172;
        public const int yPos_6 = 208;
        public const int yPos_7 = 242;
        public const int yPos_8 = 278;
        public const int yPos_9 = 314;
        public const int yPos_10 = 354;

        public const int xPos_0 = 13;
        public const int xPos_1 = 48;
        public const int xPos_2 = 84;
        public const int xPos_3 = 119;
        public const int xPos_4 = 154;
        public const int xPos_5 = 189;
        public const int xPos_6 = 224;
        public const int xPos_7 = 259;
        public const int xPos_8 = 294;
        public const int xPos_9 = 329;
        public const int xPos_10 = 364;
    }
    class Positions
    {
        Pos[] positions = new Pos[39];

        Pos GetCoord(int pos)
        {
            return positions[pos];
        }

        void fillPositions()
        {
            positions[0] = new Pos(PosConst.xPos_6, PosConst.yPos_0);
            positions[1] = new Pos(PosConst.xPos_6, PosConst.yPos_1);
            positions[2] = new Pos(PosConst.xPos_6, PosConst.yPos_2);
            positions[3] = new Pos(PosConst.xPos_6, PosConst.yPos_3);

            positions[4] = new Pos(PosConst.xPos_6, PosConst.yPos_4);
            positions[5] = new Pos(PosConst.xPos_7, PosConst.yPos_4);
            positions[6] = new Pos(PosConst.xPos_8, PosConst.yPos_4);
            positions[7] = new Pos(PosConst.xPos_9, PosConst.yPos_4);
            positions[8] = new Pos(PosConst.xPos_10, PosConst.yPos_4);

            positions[9] = new Pos(PosConst.xPos_10, PosConst.yPos_5);
            positions[10] = new Pos(PosConst.xPos_10, PosConst.yPos_6);

            positions[11] = new Pos(PosConst.xPos_9, PosConst.yPos_6);
            positions[12] = new Pos(PosConst.xPos_8, PosConst.yPos_6);
            positions[13] = new Pos(PosConst.xPos_7, PosConst.yPos_6);
            positions[14] = new Pos(PosConst.xPos_6, PosConst.yPos_6);

            positions[15] = new Pos(PosConst.xPos_6, PosConst.yPos_7); 
            positions[16] = new Pos(PosConst.xPos_6, PosConst.yPos_8);
            positions[17] = new Pos(PosConst.xPos_6, PosConst.yPos_9);
            positions[18] = new Pos(PosConst.xPos_6, PosConst.yPos_10);

            positions[19] = new Pos(PosConst.xPos_5, PosConst.yPos_10);
            positions[20] = new Pos(PosConst.xPos_4, PosConst.yPos_10);

            positions[21] = new Pos(PosConst.xPos_4, PosConst.yPos_9);
            positions[22] = new Pos(PosConst.xPos_4, PosConst.yPos_8);
            positions[23] = new Pos(PosConst.xPos_4, PosConst.yPos_7);
            positions[24] = new Pos(PosConst.xPos_4, PosConst.yPos_6);

            positions[25] = new Pos(PosConst.xPos_3, PosConst.yPos_6);
            positions[26] = new Pos(PosConst.xPos_2, PosConst.yPos_6);
            positions[27] = new Pos(PosConst.xPos_1, PosConst.yPos_6);
            positions[28] = new Pos(PosConst.xPos_0, PosConst.yPos_6);

            positions[29] = new Pos(PosConst.xPos_0, PosConst.yPos_5);
            positions[30] = new Pos(PosConst.xPos_0, PosConst.yPos_4);

            positions[31] = new Pos(PosConst.xPos_1, PosConst.yPos_4);
            positions[32] = new Pos(PosConst.xPos_2, PosConst.yPos_4);
            positions[33] = new Pos(PosConst.xPos_3, PosConst.yPos_4);
            positions[34] = new Pos(PosConst.xPos_4, PosConst.yPos_4);

            positions[35] = new Pos(PosConst.xPos_4, PosConst.yPos_3);
            positions[36] = new Pos(PosConst.xPos_4, PosConst.yPos_2);
            positions[37] = new Pos(PosConst.xPos_4, PosConst.yPos_1);
            positions[38] = new Pos(PosConst.xPos_4, PosConst.yPos_0);

            positions[39] = new Pos(PosConst.xPos_5, PosConst.yPos_0);
        }

    }
}
