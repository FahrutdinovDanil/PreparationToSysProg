using System;
using System.Collections.Generic;
using System.Text;

namespace Bilet15
{
    public interface IntUnitRange
    {
        public double Health { get; set; }
        public double Damage { get; set; }
        public double ArrowsCount { get; set; }
        public double Range { get; set; }
        public double CarryWeight { get; set; }
    }
}
