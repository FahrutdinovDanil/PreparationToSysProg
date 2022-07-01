using System;
using System.Collections.Generic;
using System.Text;

namespace Bilet16.Units
{
    class Archer : IntUnitRange
    {
        public Archer(double hp, double damage, double arrowsc, double range)
        {
            Health = hp;
            Damage = damage;
            ArrowsCount = arrowsc;
            Range = range;
        }

        public Archer()
        {

        }

        public double Health { get; set; }
        public double Damage { get; set; } = 10;
        public double ArrowsCount { get; set; } = 100;
        public double Range { get; set; }

        public void GetWound(double damage)
        {
            Health -= damage;
        }

    }
}
