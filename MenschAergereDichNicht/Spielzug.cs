using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenschAergereDichNicht
{
    static class Zugstatus
    {
        public const int wuerfeln = 0;
        public const int ziehen = 1;
    }
    class Spielzug
    {
        internal Player spieler { get; set; }
        internal int zugstatus { get; set; }
    }
}
