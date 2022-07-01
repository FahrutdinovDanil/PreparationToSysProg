using Bilet16.Units;
using System;

namespace Bilet16
{
    public class Program
    {
        //Классы и объекты — это два основных аспекта объектно-ориентированного программирования.
        //    Класс — это автономный, независимый набор переменных и функций, которые работают вместе для выполнения одной или 
        //    нескольких конкретных задач, в то время как объекты являются отдельными экземплярами класса.
        static void Main(string[] args)
        {
            Barracks barracks = new Barracks();
            ArcherTower archerTower = new ArcherTower();
            Archer archer = new Archer();
            var archer1 = barracks.CreateArcher();
            var archer2 = barracks.CreateArcher();
            archerTower.RemoteUnits(archer2);
            archerTower.RemoteUnits(archer2);
            archerTower.RemoteUnits(archer2);

            archerTower.DistanceAttack(archer1);
        }
    }
}
