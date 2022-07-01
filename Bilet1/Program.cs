using System;

namespace Bilet1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rabochii rabochii1 = new Rabochii("Рабочий", 50, 100, 55, "Саня", 40, "Работаю, не отвлекай!");
            Soldat soldat1 = new Soldat("Солдат", 100, 70, 30, "Филипп", 120, "Охраняю, не отвлекай!");
            Lecar lecar1 = new Lecar("Лекарь", 80, 50, 40, "Влад", 120, "Лечу, не отвлекай!");
            Console.WriteLine(rabochii1);
            rabochii1.Service();
            Console.WriteLine(soldat1);
            soldat1.Service();
            Console.WriteLine(lecar1);
            lecar1.Service();
        }


        public class Rabochii : IUnits
        {
            public Rabochii(string class1, int hp, int mana, int age, string name, int damage, string message)
            {
                this.class1 = class1;
                this.hp = hp;
                this.mana = mana;
                this.age = age;
                this.name = name;
                this.damage = damage;
                this.message = message;
            }

            public override string ToString()
            {
                return $"Здоровье юнита : {hp} , Мана юнита : {mana} , Возраст юнита : {age} , Имя : {name} , Урон юнита : {damage} , Он говорит : {message} , Его класс : {class1}!! ";
            }

            public string class1 { get; set; }
            public int hp { get; set; }
            public int mana { get; set; }
            public int age { get; set; }
            public string name { get; set; }
            public int damage { get; set; }
            public string message { get; set; }

            public void Service()
            {
                Console.WriteLine("Рабочий пашет!");
            }
        }
        public class Soldat : IUnits
        {
            public Soldat(string class1, int hp, int mana, int age, string name, int damage, string message)
            {
                this.class1 = class1;
                this.hp = hp;
                this.mana = mana;
                this.age = age;
                this.name = name;
                this.damage = damage;
                this.message = message;
            }

            public override string ToString()
            {
                return $"Здоровье юнита : {hp} , Мана юнита : {mana} , Возраст юнита : {age} , Имя : {name} , Урон юнита : {damage} , Он говорит : {message} , Его класс : {class1}!! ";
            }

            public string class1 { get; set; }
            public int hp { get; set; }
            public int mana { get; set; }
            public int age { get; set; }
            public string name { get; set; }
            public int damage { get; set; }
            public string message { get; set; }

            public void Service()
            {
                Console.WriteLine("Солдат охраняет!");
            }
        }
        public class Lecar : IUnits
        {
            public Lecar(string class1, int hp, int mana, int age, string name, int damage, string message)
            {
                this.class1 = class1;
                this.hp = hp;
                this.mana = mana;
                this.age = age;
                this.name = name;
                this.damage = damage;
                this.message = message;
            }

            public override string ToString()
            {
                return $"Здоровье юнита : {hp} , Мана юнита : {mana} , Возраст юнита : {age} , Имя : {name} , Урон юнита : {damage} , Он говорит : {message} , Его класс : {class1}!! ";
            }

            public string class1 { get; set; }
            public int hp { get; set; }
            public int mana { get; set; }
            public int age { get; set; }
            public string name { get; set; }
            public int damage { get; set; }
            public string message { get; set; }

            public void Service()
            {
                Console.WriteLine("Лекарь лечит!");
            }
        }
    }
}