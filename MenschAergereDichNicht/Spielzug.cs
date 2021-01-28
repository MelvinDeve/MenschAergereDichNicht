using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenschAergereDichNicht
{
    static class Zugstatus
    {
        public const int spielVorbei = -1;
        public const int ersterWurf = 0;
        public const int hausVoll2 = 1;
        public const int hausVoll3 = 2;
        public const int ziehen = 3;
        public const int rausgehen = 5;
        public const int vorHausWegziehen = 6;
        public const int naechsterSpieler = 7;
    }
    class Spielzug
    {
        internal int spieler { get; set; }
        internal int zugstatus { get; set; }
    }
}
