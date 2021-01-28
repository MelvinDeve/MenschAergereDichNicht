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
            }else if(playField.checkSameColPos(figures, 0) && !playField.checkSameColPos(figures, 0+diceRoll))
            {
                aktZug.zugstatus = Zugstatus.rausgehen;
            }else if (home.numberInHouse(figures)/*+anEndstation*/ == 4)
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
                aktZug.zugstatus = Zugstatus.ziehen;
            }
            /*
             * if(geworfen==6 && Min 1 im Haus && keiner vor haus){
             *      zugstatus = rausziehen;
             * }else if(einer vor haus && keiner auf vor haus+geworfen) {
             *      nur vor haus ziehen zulaessig;
             *      (zugstatus = vorHausWegziehen);
             * }else if(imHaus+anEndstation == 4){
             *      if(zugstatus == hausVoll3){
             *          zugstatus = naechsterSpieler;
             *      }else{
             *          zugstatus++;
             *      }
             * }else if(keinerKannGehen){
             *      zugstatus = naechsterSpieler;
             * }else{
             *      zugstatus = ziehen;
             *      (danach if zahl = 6{zugstatus = erster wurf})
             * }
             * 
             */
        }

    }
}
