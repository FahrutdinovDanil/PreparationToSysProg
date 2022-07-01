using System;
using System.Collections.Generic;
using System.Text;

namespace Bilet13.WeaponsType
{
    interface IRangeWeapons : IUnit
    {
        int Range { get; }
        
        int Chamber { get; }

    }
}
