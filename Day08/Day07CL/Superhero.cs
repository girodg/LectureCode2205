using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public enum Superpower
    {
        Speed, Invisibility, Strength, Money
    }
    public class Superhero : Person
    {
        public Superpower Power { get; set; }
        public string Identity { get; set; }
        public Superhero(string name, int age, Superpower power, string identity) : base(name, age)
        {
            Power = power;
            Identity = identity;
            Console.WriteLine($"\tSuperhero ({identity})");
        }
    }
}
