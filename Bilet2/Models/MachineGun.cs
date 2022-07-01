using System;
using System.Collections.Generic;
using System.Text;

namespace Bilet2.Models
{
    public class MachineGun
    {
        public int Damage { get; set; } = 30;
        public int Capacity { get; set; } = 200;
        public string Type { get; set; } = "15мм";

        public void Hit()
        {
            Random rnd = new Random();
            var hit = rnd.Next(1, Damage);
            var capacity = Capacity - 1;
            Console.WriteLine($"Machine-gun hit a enemy: {hit}, Capacity: {capacity}, Type: {Type}");
        }
    }
}
