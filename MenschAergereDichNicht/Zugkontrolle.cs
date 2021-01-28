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
        List<Button> greenFigures;
        List<Button> redFigures;
        List<Button> blueFigures;
        List<Button> yellowFigures;

        public Zugkontrolle(List<Button> _greenFigures, List<Button> _redFigures, List<Button> _blueFigures, List<Button> _yellowFigures)
        {
            greenFigures = _greenFigures;
            redFigures = _redFigures;
            blueFigures = _blueFigures;
            yellowFigures = _yellowFigures;
        }

        public void checkWurf(Spielzug aktZug, int diceRoll, Figure[] figures)
        {
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
