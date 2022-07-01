using System;
using System.Collections.Generic;
using System.Text;

namespace Bilet15
{
    public interface IntUnitHeal
    {
        public double Health { get; set; }
        public double Damage { get; set; }
        public double Heal { get; set; }
        public double Range { get; set; }
        public double CarryWeight { get; set; }
    }
}
