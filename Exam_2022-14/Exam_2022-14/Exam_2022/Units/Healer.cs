using System;
using System.Collections.Generic;
using System.Text;

namespace Bilet14.Units
{
    class Healer : IntUnit
    {
        public delegate void AccountHandler(string message);
        public event AccountHandler Notify;
        public Healer(double hp, double damage, double armor, double movespeed)
        {
            Hp = hp;
            Damage = damage;
            Armor = armor;
            MoveSpeed = movespeed;
        }

        public Healer()
        {

        }

        public double Hp { get; set; }
        public string Name { get; set; } = "vlad";
        public double Damage { get; set; }
        public double Armor { get; set; }
        public double MoveSpeed { get; set; }
        public void UnitInfo(IntUnit unit)
        {
            Notify?.Invoke($"{GetType().Name} health {Hp}");
        }

        public void Heal(IntUnit unit)
        {
            unit.Hp += unit.Hp * 0.02;
            Notify?.Invoke($"Heal: +20% hp {unit.Hp}");
        }
    }
}
