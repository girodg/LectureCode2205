using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public enum Superpower
    {
        Speed, Invisibility, Strength, Money, Regeneration
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

        public override void WhoAmI()
        {
            //to FULLY override, don't call the base version.
            //to extend, call the base version 
            base.WhoAmI();
            Console.WriteLine($"\tI am {Identity} and I can {Power}");
        }
        public override string ToString()
        {
            return $"I am {Identity} and I can {Power}";
        }
    }
}
