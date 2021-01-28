﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MenschAergereDichNicht
{
    static class PosConst
    {
        public const int yPos_0 = 0;
        public const int yPos_1 = 36;
        public const int yPos_2 = 72;
        public const int yPos_3 = 108;
        public const int yPos_4 = 146;
        public const int yPos_5 = 178;
        public const int yPos_6 = 214;
        public const int yPos_7 = 248;
        public const int yPos_8 = 284;
        public const int yPos_9 = 320;
        public const int yPos_10 = 360;

        public const int xPos_0 = 13+9;
        public const int xPos_1 = 48 + 9;
        public const int xPos_2 = 84 + 9;
        public const int xPos_3 = 119 + 9;
        public const int xPos_4 = 154 + 9;
        public const int xPos_5 = 189 + 9;
        public const int xPos_6 = 224 + 9;
        public const int xPos_7 = 259 + 9;
        public const int xPos_8 = 294 + 9;
        public const int xPos_9 = 329 + 9;
        public const int xPos_10 = 364 + 9;
    }
    class Positions
    {
        Pos[] positions = new Pos[40];
        Pos defaultPosition = new Pos(0, 0);
        public Pos GetCoord(int pos)
        {
            return positions[pos];
        }

        bool jemandVorHaus(List<Button> figures, int color)
        {
            //TO DO: schaut ob jemand von der eigenen farbe direkt vor dem haus steht sodass keiner raus kann
            return false;
        }

        public int GetPos(Thickness th)
        {
            for(int i = 0; i<39; i++)
            {
                if (positions[i].xPos == th.Left && positions[i].yPos == th.Top)
                {
                    return i;
                }
            }
            return -1;
        }

        public int incrementPosition(int currentPos, int diceNumber)
        {
            int returnPos = currentPos + diceNumber;
            if (returnPos > 39)
            {
                returnPos -= 39;
            }
            return returnPos;
        }

        public Positions()
        {
            fillPositions();
        }

        public void fillPositions()
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
