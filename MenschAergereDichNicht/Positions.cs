using System;
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
        public const int yPos_0 = -6;
        public const int yPos_1 = 30;
        public const int yPos_2 = 66;
        public const int yPos_3 = 102;
        public const int yPos_4 = 138;
        public const int yPos_5 = 172;
        public const int yPos_6 = 208;
        public const int yPos_7 = 242;
        public const int yPos_8 = 278;
        public const int yPos_9 = 312;
        public const int yPos_10 = 348;

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
        /// <summary>
        /// Checks if a Pin of the same color is on a projected Position
        /// </summary>
        /// <param name="figures"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        public bool checkSameColPos(Figure[] figures, int position)
        {
            foreach(Figure figure in figures)
            {
                if (figure.relPos == position) 
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// returns index of a given Position 
        /// </summary>
        /// <param name="th"></param>
        /// <returns></returns>
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

        public int anzFigurenZugfaehig(Figure[] figures, int diceRoll)
        {
            bool tempZugfaehig;
            int zugfaehig = 0;
            foreach (Figure figure in figures)
            {
                tempZugfaehig = true;
                if (figure.relPos >= 0)
                {
                    if (figure.relPos + diceRoll > 43)
                    {
                        tempZugfaehig = false;
                    }
                    else
                    {
                        foreach (Figure secondFigure in figures)
                        {
                            if (figure.relPos + diceRoll == secondFigure.relPos)
                            {
                                tempZugfaehig = false;
                            }
                        }
                    }
                }
                if (tempZugfaehig)
                {
                    zugfaehig++;
                }
            }
            return zugfaehig;
        }

        /// <summary>
        /// increments Position by given amount
        /// </summary>
        /// <param name="currentPos"></param>
        /// <param name="diceNumber"></param>
        /// <returns></returns>
        public int incrementPosition(int currentPos, int diceNumber)
        {
            int returnPos = currentPos + diceNumber;
            if (returnPos > 39)
            {
                returnPos -= 39;
            }
            return returnPos;
        }

        public int wichFigure(Figure[] figures, Pos posToCheck)
        {
            for (int i = 0; i < 4; i++)
            {
                if (positions[(figures[i].relPos)] == posToCheck)
                {
                    return i;
                }
            }
            return -1;
        }
        public Positions()
        {
            fillPositions();
        }
        /// <summary>
        /// fills in the needed Positions on the Board 
        /// </summary>
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
