using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Day06
{
    internal class Program
    {
        static Dictionary<int, ulong> _fibData = new Dictionary<int, ulong>();
        static void Main(string[] args)
        {
            List<int> nums = new() { 5, 7, 13, 42, 3, 1 };
            int searchNum = 13;
            int index = LinearSearch(nums, searchNum);
            if(index >= 0)
                Console.WriteLine($"{searchNum} is at index {index}.");
            else
                Console.WriteLine($"{searchNum} was not found.");

            searchNum = 100; 
            index = LinearSearch(nums, searchNum);
            if (index >= 0)
                Console.WriteLine($"{searchNum} is at index {index}.");
            else
                Console.WriteLine($"{searchNum} was not found.");

            Console.WriteLine("------------FIB-------------");
            _fibData.Add(0, 0);
            _fibData[1] = 1;
            Stopwatch sw = new Stopwatch();
            for (int N = 0; N < 145; N++)
            {
                sw.Restart();
                ulong result = Fib2(N);
                sw.Stop();
                Console.Write($"Fib({N}) = {result}");
                Console.CursorLeft = 40;
                Console.WriteLine($"{sw.ElapsedMilliseconds}ms");
            }
        }
        static ulong Fib2(int N)
        {
            if (_fibData.TryGetValue(N, out ulong result))
                return result;

            result = Fib2(N - 1) + Fib2(N - 2);
            _fibData[N] = result;
            return result;
        }

        static ulong Fib(int N)
        {
            if (N == 0) return 0;
            if (N == 1) return 1;

            ulong result = Fib(N - 1) + Fib(N - 2);
            return result;
        }

        private static int LinearSearch(List<int> nums, int searchItem)
        {
            int foundIndex = -1;//-1 means not found
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == searchItem)
                {
                    foundIndex = i;
                    break;
                }
            }
            return foundIndex;
        }
    }
}
