using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_2022_Blazor.Data
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public DateTime Time { get; set; }

        public static List<Person> lst = new List<Person>();

        public Person(string name, string surname, DateTime time)
        {
            this.Name = name;
            this.Surname = surname;
            this.Time = time;
        }
        public Person()
        {

        }

        public static void AddToList(string surname1, string name1, DateTime time1)
        {
            Person pers = new Person(surname1, name1, time1);
            lst.Add(pers);
        }

        public static List<Person> GetPerson()
        {
            return lst;
        }

        public static void DelList(string surname1, string name1, DateTime time1)
        {
            Person pers = new Person(surname1, name1, time1);
            var last = Enumerable.Range(0, 100).ToList().Last();
            try 
            {
                lst.Remove(lst.Last());
            }
            catch
            {
                Console.WriteLine("Список пуст!");
            }
        }
    }
}
