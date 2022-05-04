using System;
using System.Collections.Generic;

namespace Day02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[4];
            nums[1] = 5;//indexes are zero-based
            ArrayChallenge();

            List<string> jl = new List<string>(10);// { "Batman" };
            Info(jl);
            jl.Add("Superman");
            Info(jl);
            jl.Add("Wonder Woman");
            jl.Add("Flash");
            jl.Add("Green Lantern");
            jl.Add("Batman");//Count: 5, Capacity: 8
            Info(jl);
            jl.Add("Aquaman");
            jl.Add("Wonder Twins");
            jl.Add("Nightwing");
            jl.Add("Martian Manhunter");
            Info(jl);
            jl.Sort();
            Print(jl);


            ListChallenge();
        }

        private static void Print(List<string> jl)
        {
            for (int i = 0; i < jl.Count; i++)
            {
                Console.WriteLine(jl[i]);
            }
            //OR
            //foreach (string super in jl)
            //{
            //    Console.WriteLine(super);
            //}
        }

        private static void Info(List<string> jl)
        {
            //Count: # of items in the list
            //Capacity: size/length of the internal array
            Console.WriteLine($"Count: {jl.Count}\tCapacity: {jl.Capacity}");
        }

        static void ListChallenge()
        {
            List<double> grades = new(10);
            Random rando = new();
            for (int i = 0; i < 10; i++)
            {
                grades.Add(rando.NextDouble() * 100);
            }
            PrintGrades(grades);
        }

        private static void PrintGrades(List<double> grades)
        {
            Console.ReadKey();
            Console.Clear();
            string header = "---------May GRADES----------";
            int midX = Console.WindowWidth / 2 - header.Length / 2;
            int midY = Console.WindowHeight / 2 - 6;
            Console.SetCursorPosition(midX, midY);
            Console.WriteLine(header);
            foreach (double grade in grades)
            {
                //$ - interpolated string
                //,7 = right-align with 7 spaces
                //:N2 = number with 2 decimal places
                Console.CursorLeft = midX + 9;
                if (grade < 59.5) Console.BackgroundColor = ConsoleColor.Red;
                else if (grade < 69.5) Console.ForegroundColor = ConsoleColor.DarkYellow;
                else if (grade < 79.5) Console.ForegroundColor = ConsoleColor.Yellow;
                else if (grade < 89.5) Console.ForegroundColor = ConsoleColor.Blue;
                else  Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{grade,7:N2}");
                Console.ResetColor();
            }
        }

        static void ArrayChallenge()
        {
            int[] nums = new int[10];
            Random randy = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = randy.Next(100);
            }
            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }
        }
    }
}
