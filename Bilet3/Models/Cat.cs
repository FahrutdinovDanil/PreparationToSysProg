using System;
using System.Collections.Generic;
using System.Text;

namespace Bilet3.Models
{
    class Cat : Pet
    {
        public string Name { get; set; } = "Cat";
        public string Breed { get; set; } = "Siamskaya";
        public int Age { get; set; } = 2;

        public override void Showinfo()
        {
            Console.WriteLine($"Name: {Name}, Breed: {Breed}, Age: {Age} ");
        }
    }
}
