using System;
using System.Collections.Generic;
using System.Text;

namespace Bilet2.Models
{
    public class Gun
    {
        public int Damage { get; set; } = 20;
        public int Capacity { get; set; } = 30;
        public string Type { get; set; } = "5,45мм";

        public void Hit()
        {
            Random rnd = new Random();
            var hit = rnd.Next(1, Damage);
            var capacity = Capacity - 1;
            Console.WriteLine($"Gun hit a enemy: {hit}, Capacity: {capacity}, Type: {Type}");
        }
    }
}
