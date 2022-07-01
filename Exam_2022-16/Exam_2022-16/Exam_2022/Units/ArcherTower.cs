using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bilet16.Units
{
    class ArcherTower : RemoteUnit
    {
        Archer arch = new Archer();
        public List<Archer> unitsList { get; }
        public ArcherTower()
        {
            unitsList = new List<Archer>();
        }
        

        public int MaxGarrison => 5;

        public void DistanceAttack(IntUnitRange unit)
        {
            if (unitsList.Count() > 0)
            {
                
                var currentDamage = unitsList.Count * arch.Damage;

                Console.WriteLine($"{GetType().Name} shoots with a bow {currentDamage}");
                unit.GetWound(currentDamage);
            }

            else
            {
                Console.WriteLine("Garrison empty.");
            }
        }


        public void RemoteUnits(Archer unit)
        {
            if (unitsList.Count() < MaxGarrison)
            {
                unitsList.Add(unit);
            }
            else
            {
                Console.WriteLine("ArcherTower is fuul.");
            }

        }
    }
}
