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
            string itemToRemove = "Chicken Salad";
            RemoveMenuItem(menu, itemToRemove);
            RemoveMenuItem(menu, "Chicken nuggets");
            PrintMenu(menu);
            string menuItem = "Double Burger";
            CheckPrice(menu, menuItem);
            CheckPrice(menu, "Chicken nuggets");
            Console.ReadKey();

            DictionaryChallenge();
        }

        private static void CheckPrice(Dictionary<string, float> menu, string menuItem)
        {
            if (menu.TryGetValue(menuItem, out float price))
            {
                menu[menuItem] = price + price * 0.05F;
                Console.WriteLine($"{menuItem} was {price,7:C2}. It now costs {menu[menuItem],7:C2}. Thanks Putin.");
            }
            else
                Console.WriteLine($"{menuItem} is not on the menu.");
        }

        private static void RemoveMenuItem(Dictionary<string, float> menu, string itemToRemove)
        {
            bool wasRemoved = menu.Remove(itemToRemove);
            if(wasRemoved)
                Console.WriteLine($"{itemToRemove} was removed from the menu.");
            else
                Console.WriteLine($"{itemToRemove} was not found.");
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
            Dictionary<string, double> pg2 = new Dictionary<string, double>()
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

            PrintGrades(pg2);
            DropStudent(pg2);
            CurveStudent(pg2);
        }

        static void PrintGrades(Dictionary<string, double> course)
        {
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("-------Grades-------");
            foreach (var student in course)
            {
                double grade = student.Value;
                if (grade < 59.5) Console.BackgroundColor = ConsoleColor.Red;
                else if (grade < 69.5) Console.ForegroundColor = ConsoleColor.DarkYellow;
                else if (grade < 79.5) Console.ForegroundColor = ConsoleColor.Yellow;
                else if (grade < 89.5) Console.ForegroundColor = ConsoleColor.Blue;
                else Console.ForegroundColor = ConsoleColor.Green;

                Console.Write($"{grade,7:N2}");

                Console.ResetColor();

                Console.WriteLine($" {student.Key}");
            }
        }

        static void DropStudent(Dictionary<string, double> course)
        {
            Console.Clear();
            do
            {
                PrintGrades(course);
                Console.Write("Name of student to drop: ");
                string name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name)) break;

                bool wasRemoved = course.Remove(name);
                if (wasRemoved)
                    Console.WriteLine($"{name} was removed from the course.");
                else
                    Console.WriteLine($"{name} was not found.");

            } while (true);
        }
        static void CurveStudent(Dictionary<string, double> course)
        {
            Console.Clear();
            do
            {
                PrintGrades(course);
                Console.Write("Name of student to curve: ");
                string name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name)) break;

                if(course.TryGetValue(name, out double grade))
                {
                    grade = (grade < 95) ? grade + 5 : 100;
                    course[name] = grade;//put the new value back into the dictionary
                }
                else
                    Console.WriteLine($"{name} is not on the roster.");


            } while (true);
        }

        static Random rando = new Random();
        private static double GetGrade()
        {
            return rando.NextDouble() * 100;
        }
    }
}
