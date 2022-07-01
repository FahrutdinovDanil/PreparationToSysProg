using System;
using System.Collections.Generic;
using System.Text;

namespace Bilet13.WeaponsType
{
    interface IThrowableWeapon : IUnit
    {
        int Range { get; }
        int RadiusOfDefeat { get; }
    }
}
