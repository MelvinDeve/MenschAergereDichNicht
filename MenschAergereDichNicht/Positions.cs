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
        public const int yPos_9 = 318;
        public const int yPos_10 = 354;

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
        PositionGarage PosGar = new PositionGarage();
        PositionHome PosHome = new PositionHome();

        Pos[] positions = new Pos[40];
        Pos defaultPosition = new Pos(0, 0);

        public Pos GetCoord(Figure fig)
        {
            int absolutePos;

            if (fig.relPos <= 39 && fig.relPos >= 0)
            {
                if ((fig.relPos + fig.diff) > 39)
                {
                    absolutePos = fig.relPos + fig.diff - 40;
                }
                else
                {
                    absolutePos = fig.relPos + fig.diff;
                }
                return positions[absolutePos];
            }
            else if (fig.relPos > 39)
            {
                switch (fig.color)
                {
                    case 0:
                        return PosGar.positions_garage_blue[fig.relPos - 40];
                    case 1:
                        return PosGar.positions_garage_red[fig.relPos - 40];
                    case 2:
                        return PosGar.positions_garage_yellow[fig.relPos - 40];
                    case 3:
                        return PosGar.positions_garage_green[fig.relPos - 40];
                    default:
                        break;
                }
            }
            return PosHome.defaultPosition;
        }

        public Figure maybeSendHome(Figure[] blueFigures, Figure[] redFigures, Figure[] yellowFigures, Figure[] greenFigures, Figure fig)
        {
            if(blueFigures[0].color != fig.color)
            {
                foreach(Figure blueFig in blueFigures)
                {
                    if (blueFig.relPos >= 0)
                    {
                        if (relInAbsPos(blueFig) == relInAbsPos(fig))
                        {
                            return blueFig;
                        }
                    }
                }
            }
            if (redFigures[0].color != fig.color)
            {
                foreach (Figure redFig in redFigures)
                {
                    if (redFig.relPos >= 0)
                    {
                        if (relInAbsPos(redFig) == relInAbsPos(fig))
                        {
                            return redFig;
                        }
                    }
                }
            }
            if (yellowFigures[0].color != fig.color)
            {
                foreach (Figure yellowFig in yellowFigures)
                {
                    if (yellowFig.relPos >= 0)
                    {
                        if (relInAbsPos(yellowFig) == relInAbsPos(fig))
                        {
                            return yellowFig;
                        }
                    }
                }
            }
            if (greenFigures[0].color != fig.color)
            {
                foreach (Figure greenFig in greenFigures)
                {
                    if (greenFig.relPos >= 0)
                    {
                        if (relInAbsPos(greenFig) == relInAbsPos(fig))
                        {
                            return greenFig;
                        }
                    }
                }
            }
            return null;
        }

        public int relInAbsPos(Figure fig)
        {
            int absPos;
            if ((fig.relPos + fig.diff) > 39)
            {
                absPos = fig.relPos + fig.diff - 40;
            }
            else
            {
                absPos = fig.relPos + fig.diff;
            }
            return absPos;
        }

        public Pos SendHome(Figure[] figures, Figure fig)
        {
            int tempRelPos = -1;
            bool fertig = false;

            while (!fertig)
            {
                fertig = true;
                foreach (Figure figure in figures)
                {
                    if (figure.relPos == tempRelPos)
                    {
                        tempRelPos -= 1;
                        fertig = false;
                        break;
                    }
                }
            }

            fig.relPos = tempRelPos;
            tempRelPos = (tempRelPos + 1) * -1;
            
                switch (fig.color)
                {
                    case 0:
                        
                    return PosHome.positions_home_blue[tempRelPos];
                    case 1:
                    return PosHome.positions_home_red[tempRelPos];
                    case 2:
                    return PosHome.positions_home_yellow[tempRelPos];
                    case 3:
                    return PosHome.positions_home_green[tempRelPos];
                    default:
                    return PosHome.defaultPosition;
                }
            
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

        public int anzFigurenInEndpos(Figure[] figures)
        {
            int anz = 0;
            int verglWert = 43;
            int prevVerglWert = 44;
            while (verglWert < prevVerglWert&& verglWert>39)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (figures[i].relPos == verglWert)
                    {
                        anz++;
                        verglWert--;
                        break;
                    }
                }
                prevVerglWert--;
            }
            return anz;
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
        /// <summary>
        /// uses figure array and location(in this case margin) to determine which figure 
        /// </summary>
        /// <param name="figures"></param>
        /// <param name="marginToCheck"></param>
        /// <returns></returns>
        public int whichFigure(Figure[] figures, Thickness marginToCheck)
        {
            Pos posToCheck = new Pos(marginToCheck.Left, marginToCheck.Top);
            int[] absolutePos = new int[4];
            for (int i = 0; i < 4; i++)
            {
                if (figures[i].relPos > 39)
                {
                    switch (figures[i].color)
                    {
                        case 0:
                                if (PosGar.positions_garage_blue[figures[i].relPos - 40].xPos == posToCheck.xPos &&
                                PosGar.positions_garage_blue[figures[i].relPos - 40].yPos == posToCheck.yPos)
                                    return i;
                            break;
                        case 1:
                                if (PosGar.positions_garage_red[figures[i].relPos - 40].xPos == posToCheck.xPos &&
                                PosGar.positions_garage_red[figures[i].relPos - 40].yPos == posToCheck.yPos)
                                    return i;
                            break;
                        case 2:
                                if (PosGar.positions_garage_yellow[figures[i].relPos - 40].xPos == posToCheck.xPos &&
                                PosGar.positions_garage_yellow[figures[i].relPos - 40].yPos == posToCheck.yPos)
                                    return i;
                            break;
                        case 3:
                                if (PosGar.positions_garage_green[figures[i].relPos-40].xPos == posToCheck.xPos &&
                                    PosGar.positions_garage_green[figures[i].relPos-40].yPos == posToCheck.yPos)
                                    return i;
                            break;
                        default:
                            break;
                    }
                }
                else if (figures[i].relPos < 0)
                {
                    switch (figures[i].color)
                    {
                        case 0:
                            for (int j = 0; j < 4; j++)
                            {
                                if (PosHome.positions_home_blue[j].xPos == posToCheck.xPos &&
                                    PosHome.positions_home_blue[j].yPos == posToCheck.yPos)
                                    return i;
                            }
                            break;
                        case 1:
                            for (int j = 0; j < 4; j++)
                            {
                                if (PosHome.positions_home_red[j].xPos == posToCheck.xPos &&
                                    PosHome.positions_home_red[j].yPos == posToCheck.yPos)
                                    return i;
                            }
                            break;
                        case 2:
                            for (int j = 0; j < 4; j++)
                            {
                                if (PosHome.positions_home_yellow[j].xPos == posToCheck.xPos &&
                                    PosHome.positions_home_yellow[j].yPos == posToCheck.yPos)
                                    return i;
                            }
                            break;
                        case 3:
                            for (int j = 0; j < 4; j++)
                            {
                                if (PosHome.positions_home_green[j].xPos == posToCheck.xPos &&
                                    PosHome.positions_home_green[j].yPos == posToCheck.yPos)
                                    return i;
                            }
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    if ((figures[i].relPos + figures[i].diff) > 39)
                    {
                        absolutePos[i] = figures[i].relPos + figures[i].diff - 40;
                    }
                    else
                    {
                        absolutePos[i] = figures[i].relPos + figures[i].diff;
                    }
                    if (positions[absolutePos[i]].xPos == posToCheck.xPos &&
                        positions[absolutePos[i]].yPos == posToCheck.yPos)
                    {
                        return i;
                    }
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
