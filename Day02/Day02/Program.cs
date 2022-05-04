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

            List<string> jl = new List<string>() { "Batman" };
            jl.Add("Superman");
            jl.Add("Wonder Woman");

            ListChallenge();
        }

        static void ListChallenge()
        {
            List<double> grades = new();
            Random rando = new();
            for (int i = 0; i < 10; i++)
            {
                grades[i] = rando.NextDouble() * 100;
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
