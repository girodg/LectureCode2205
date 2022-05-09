using System;

namespace Day05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }

            DoIt(0);

            long result = Fac(5);

            Console.WriteLine("We're done.");
        }

        private static long Fac(int N)
        {
            if (N <= 1) return 1;

            long result = N * Fac(N - 1);
            return result; 
        }

        private static void DoIt(int j)
        {
            if (j < 100)//exit condition
            {
                Console.WriteLine(j);
                DoIt(j+1);
                Console.WriteLine(j);
            }
        }
    }
}
