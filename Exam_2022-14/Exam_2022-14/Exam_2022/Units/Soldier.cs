using System;
using System.Collections.Generic;
using System.Text;

namespace Bilet14.Units
{
    public class Soldier : IntUnit
    {
        public delegate void AccountHandler(string message);
        public event AccountHandler Notify;
        public Soldier(double hp, double damage, double armor, double movespeed)
        {
            Hp = hp;
            Damage = damage;
            Armor = armor;
            MoveSpeed = movespeed;
        }

        public Soldier()
        {

        }

        public double Hp { get; set; } = 120;
        public string Name { get; set; } = "vasya";
        public double Damage { get; set; } = 22;
        public double Armor { get; set; }
        public double MoveSpeed { get; set; }
        public void UnitInfo(IntUnit unit)
        {
            Notify?.Invoke($"{GetType().Name} health {Hp}");
        }
        public void Hit(IntUnit unit)
        {
            unit.Hp -= Damage;
            Notify?.Invoke($"Soldier: Hit a Enemy: {Damage}, Enemy: {unit.Name}, hp Enemy: {unit.Hp}" );
        }
    }
}
