using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenschAergereDichNicht
{
    class PositionHome
    {
        Pos[] positions = new Pos[4];
        Pos GetCoord(int pos)
        {
            return positions[pos];
        }
    }
}
