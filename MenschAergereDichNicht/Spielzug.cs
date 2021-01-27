using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenschAergereDichNicht
{
    static class Zugstatus
    {
        public const int ersterWurf = 0;
        public const int hausVoll2 = 1;
        public const int hausVoll3 = 2;
        public const int ziehen = 3;
        public const int ziehen6geworfen = 4;
    }
    class Spielzug
    {
        internal Player spieler { get; set; }
        internal int zugstatus { get; set; }
    }
}
