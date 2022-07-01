using System;
using System.Collections.Generic;
using System.Text;

namespace Bilet2.Models
{
    public class Pistol
    {
        public int Damage { get; set; } = 10;
        public int Capacity { get; set; } = 12;
        public string Type { get; set; } = "9мм";

        public void Hit()
        {
            Random rnd = new Random();
            var hit = rnd.Next(1, Damage);
            var capacity = Capacity - 1;
            Console.WriteLine($"Pistol hit a enemy: {hit}, Capacity: {capacity}, Type: {Type}");
        }
    }
}
