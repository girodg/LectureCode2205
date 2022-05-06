using System;
using System.Collections.Generic;

namespace Day03
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            DictionaryChallenge();
        }

        private static void DictionaryChallenge()
        {
            List<string> names = new List<string>()
            {
                "Arnn", "Benjamin", "Erik", "Mason", "Nicholas", "Dane", "Joyce", "Hamilton", "Aoife", "Daniel", "Brandon", 
                "Deion", "Dylan", "Aaronn", "Bob", "Michael", "Nevin"
            };
        }
    }
}
