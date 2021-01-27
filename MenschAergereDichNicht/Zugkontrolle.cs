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

        public void checkWurf(Spielzug aktZug, int diceRoll)
        {
            
        }

    }
}
