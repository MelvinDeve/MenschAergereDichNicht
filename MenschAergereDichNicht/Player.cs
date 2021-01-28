using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenschAergereDichNicht
{
    class Player
    {
        internal String Name { get; }
        internal int Farbe { get; }

        public Player(String _Name, int _Farbe)
        {
            Name = _Name;
            Farbe = _Farbe;
        }

    }
}
