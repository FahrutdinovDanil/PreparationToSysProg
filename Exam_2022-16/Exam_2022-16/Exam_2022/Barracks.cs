using Bilet16.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bilet16
{
    class Barracks
    {
        public Archer CreateArcher()
        {
            return new Archer(10, 10, 10, 10);
        }
    }
}
