using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenschAergereDichNicht
{
    class Figure
    {
        internal int relPos;
        internal int color;
        internal int diff;

        public Figure(int _relPos, int _color)
        {
            relPos = _relPos;
            color = _color;
            switch (color)
            {
                case 0:
                    diff = 0;
                    break;
                case 1:
                    diff = 10;
                    break;
                case 2:
                    diff = 20;
                    break;
                case 3:
                    diff = 30;
                    break;
                default:
                    break;
            }
        }
    }
}
