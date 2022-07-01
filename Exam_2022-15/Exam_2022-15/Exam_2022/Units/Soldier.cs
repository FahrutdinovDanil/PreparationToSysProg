using System;
using System.Collections.Generic;
using System.Text;

namespace Bilet15.Units
{
    public class Soldier : IntUnitSold
    {
        public Soldier(double hp, double damage, double weight)
        {
            Health = hp;
            Damage = damage;
            CarryWeight = weight;
        }

        public Soldier()
        {

        }

        public double Health { get; set; }
        public double Damage { get; set; }
        public double CarryWeight { get; set; }
    }
}
