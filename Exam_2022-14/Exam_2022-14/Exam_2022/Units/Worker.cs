using System;
using System.Collections.Generic;
using System.Text;

namespace Bilet14.Units
{
    class Worker : IntUnit
    {
        public delegate void AccountHandler(string message);
        public event AccountHandler Notify;
        public Worker(double hp, double damage, double armor, double movespeed)
        {
            Hp = hp;
            Damage = damage;
            Armor = armor;
            MoveSpeed = movespeed;
        }

        public Worker()
        {

        }

        public double Hp { get; set; } = 100;
        public string Name { get; set; } = "dima";
        public double Damage { get; set; }
        public double Armor { get; set; }
        public double MoveSpeed { get; set; }
        public void UnitInfo(IntUnit unit)
        {
            Notify?.Invoke($"{GetType().Name} health {Hp}");
        }
    }
}
