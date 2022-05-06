using System;
using System.Collections.Generic;
using System.Threading;

namespace Day03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            //Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("de-DE");
            //Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("de-DE");
            //3 ways to get data in:
            //1) initialization list
            //2) Add method
            //3) [ ]
            Dictionary<string, float> menu = new Dictionary<string, float>()
            {
                //KeyValuePair
                { "Cheesy Burger", 3.99F },
                { "Fries", 1.99F }
            };
            //2) Add method
            menu.Add("Double Burger", 4.99F);
            //KEYS must be unique
            try
            {
                menu.Add("Double Burger", 4.99F);//will throw an exception
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //3) [ ]
            menu["Chicken Salad"] = 5.99F;
            //will NOT throw an exception. will simply overwrite the value
            menu["Chicken Salad"] = 7.99F;
            PrintMenu(menu);

            DictionaryChallenge();
        }

        private static void PrintMenu(Dictionary<string, float> menu)
        {
            Console.Clear();
            Console.WriteLine("---Welcome to the Burger Barn---");
            foreach (KeyValuePair<string, float> item in menu)
            {
                Console.WriteLine($"{item.Value,8:C2} {item.Key}");
            }
        }

        private static void DictionaryChallenge()
        {
            List<string> names = new List<string>()
            {
                "Arnn", "Benjamin", "Erik", "Mason", "Nicholas", "Dane", "Joyce", "Hamilton", "Aoife", "Daniel", "Brandon", 
                "Deion", "Dylan", "Aaronn", "Bob", "Michael", "Nevin"
            };
            Dictionary<string, double> pg2 = new()
            {
                { names[0], GetGrade()},
                { names[1], GetGrade() }
            };
            for (int i = 2; i < names.Count; i++)
            {
                pg2.Add(names[i], GetGrade());
                //OR
                //pg2[names[i]] = GetGrade();
            }

        }

        static Random rando = new Random();
        private static double GetGrade()
        {
            return rando.NextDouble() * 100;
        }
    }
}
