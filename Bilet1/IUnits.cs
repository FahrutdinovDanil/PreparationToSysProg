using System;
using System.Collections.Generic;
using System.Text;

namespace Bilet1
{
    interface IUnits
    {
        int hp { get; set; }
        int mana { get; set; }
        int age { get; set; }
        string name { get; set; }
        int damage { get; set; }
        string message { get; set; }
    }
}
