using Bilet3.Models;
using System;

namespace Bilet3
{
    class Program
    {
        /*
         Переопределние методов - это объекты, которые вызывают метод производного класса вместо метода базового класса.  
         */
        static void Main(string[] args)
        {
            Pet pet = new Pet();
            Cat cat = new Cat();
            pet.Showinfo();
            cat.Showinfo();
        }
    }
}
