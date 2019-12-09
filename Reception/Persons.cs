using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reception
{
    public class People
    {
        public static List<Persons> persons = new List<Persons>();
        public static void Add(Persons p)
        {
            persons.Add(p);
        }

        public static void Remove(Persons p)
        {
            persons.Remove(p);
        }

        public static void Print()
        {
            if (persons.Any())
            {
                foreach (var name in persons)
                {
                    Console.WriteLine(name.ToString() + " Yet dooooolgo!!!");
                }
            }
            else
            {
                Console.WriteLine("Nobody in the hall");
            }
        }
        public static int Gym(int i) 
        {
            Console.WriteLine("Doing execise");
            i++;
            return i;
        }
        public class Persons
        {
           public Persons(string Name, int kolpod)
            {
                this.Name = Name;
                this.kolpod = kolpod;
            }
            public string Name { get; set; }
            public int kolpod { get; set; }
            public override string ToString()
            {
                return $"Name = {Name}, kolpod = {kolpod}";
            }
        }
    }
}
