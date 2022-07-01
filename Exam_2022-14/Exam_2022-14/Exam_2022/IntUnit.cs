using System;
using System.Collections.Generic;
using System.Text;

namespace Bilet14
{
    public interface IntUnit
    {
        public double Hp { get; set; }
        public string Name { get; set; }
        public double Damage { get; set; }
        public double Armor { get; set; }
        public double MoveSpeed { get; set; }
    }
}
