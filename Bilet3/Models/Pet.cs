using System;
using System.Collections.Generic;
using System.Text;

namespace Bilet3.Models
{
    public class Pet
    {
        public string Name { get; set; } = "Pet";
        public string Breed { get; set; } = "Pet";

        public virtual void Showinfo()
        {
            Console.WriteLine($"Name: {Name}, Breed: {Breed}");
        }
    }
}
