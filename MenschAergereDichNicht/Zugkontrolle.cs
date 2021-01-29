using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MenschAergereDichNicht
{
    class Zugkontrolle
    {
        PositionHome home = new PositionHome();
        Positions playField = new Positions();
       

        public void checkWurf(Spielzug aktZug, int diceRoll, Figure[] figures)
        {
            if(diceRoll == 6 && home.numberInHouse(figures) > 0 && !playField.checkSameColPos(figures, 0))
            {
                aktZug.zugstatus = Zugstatus.rausgehen;
            }else if(playField.checkSameColPos(figures, 0) && !playField.checkSameColPos(figures, 0+diceRoll) && home.numberInHouse(figures)>0)
            {
                aktZug.zugstatus = Zugstatus.vorHausWegziehen;
            }else if (home.numberInHouse(figures)+playField.anzFigurenInEndpos(figures) == 4)
            {
                if(aktZug.zugstatus == Zugstatus.hausVoll3)
                {
                    aktZug.zugstatus = Zugstatus.naechsterSpieler;
                }
                else
                {
                    aktZug.zugstatus++;
                }
            }else if (playField.anzFigurenZugfaehig(figures, diceRoll)==0)
            {
                aktZug.zugstatus = Zugstatus.naechsterSpieler;
            }
            else
            {
                int immoveableFigures = 0;
                foreach (Figure figure in figures)
                {
                    
                    if (figure.relPos < 0)
                    {
                        if (diceRoll != 6) {
                            immoveableFigures++;
                        }
                    }
                    else if ((figure.relPos + diceRoll) > 43)
                    {
                        immoveableFigures++;
                    }
                    else if ((figure.relPos + diceRoll) > 39 && (figure.relPos + diceRoll) < 44)
                    {
                        int tempPos;
                        bool zulaessigInGarage = true;
                        if (figure.relPos + 1 < 40)
                        {
                            tempPos = 40;
                        }
                        else
                        {
                            tempPos = figure.relPos + 1;
                        }

                        while (tempPos <= figure.relPos + diceRoll)
                        {
                            if (playField.checkSameColPos(figures, tempPos))
                            {
                                zulaessigInGarage = false;
                            }
                            tempPos++;
                        }
                        if (!zulaessigInGarage)
                        {
                            immoveableFigures++;
                        }

                    }
                }
                if (immoveableFigures > 3)
                {
                    aktZug.zugstatus = Zugstatus.naechsterSpieler;
                }
                else
                {
                    aktZug.zugstatus = Zugstatus.ziehen;
                }
            }
        }

    }
}
