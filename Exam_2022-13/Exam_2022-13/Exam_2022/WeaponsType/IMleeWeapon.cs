using System;
using System.Collections.Generic;
using System.Text;

namespace Bilet13.WeaponsType
{
    interface IMleeWeapon : IUnit
    {
        int Range { get; }
    }
}
