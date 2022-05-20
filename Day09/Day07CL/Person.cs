using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine($"Person ({Name})");
        }

        public virtual void WhoAmI()
        {
            Console.WriteLine($"Hi. My name is {Name} and I am {Age} years old.");
        }
    }
}
