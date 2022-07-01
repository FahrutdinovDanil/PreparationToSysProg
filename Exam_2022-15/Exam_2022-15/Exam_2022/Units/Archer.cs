using System;
using System.Collections.Generic;
using System.Text;

namespace Bilet15.Units
{
    class Archer : IntUnitRange
    {
        public Archer(double hp, double damage, double arrowsc, double range, double weight)
        {
            Health = hp;
            Damage = damage;
            ArrowsCount = arrowsc;
            Range = range;
            CarryWeight = weight;
        }

        public Archer()
        {

        }

        public double Health { get; set; }
        public double Damage { get; set; }
        public double ArrowsCount { get; set; }
        public double Range { get; set; }
        public double CarryWeight { get; set; }
    }
}
