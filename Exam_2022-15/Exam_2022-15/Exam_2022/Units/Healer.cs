using System;
using System.Collections.Generic;
using System.Text;

namespace Bilet15.Units
{
    class Healer : IntUnitHeal
    {
        public Healer(double hp, double damage, double heal, double range, double weight)
        {
            Health = hp;
            Damage = damage;
            Heal = heal;
            Range = range;
            CarryWeight = weight;
        }

        public Healer()
        {

        }

        public double Health { get; set; }
        public double Damage { get; set; }
        public double Heal { get; set; }
        public double Range { get; set; }
        public double CarryWeight { get; set; }
    }
}
