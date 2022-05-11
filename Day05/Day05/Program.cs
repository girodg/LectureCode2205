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

            string msg = "The quick brown fox jumps over the lazy dog.";
            string revMsg = Reverso(msg, 0);//start at the 0 index
            Console.WriteLine(msg);
            Console.WriteLine(revMsg);
            Console.WriteLine("We're done.");

            int[] nums = new int[] { 5, 7, 13, 42, 110 };
            Console.WriteLine();
            Print(nums);
            Swap(nums, 1, 2);
            Print(nums);
        }

        private static void Swap(int[] nums, int ndx1, int ndx2)
        {
            //int temp = nums[ndx1];
            //nums[ndx1] = nums[ndx2];
            //nums[ndx2] = temp;
            (nums[ndx2], nums[ndx1]) = (nums[ndx1], nums[ndx2]);
        }

        private static void Print(int[] nums)
        {
            foreach (var item in nums)
                Console.Write($"{item} ");
            Console.WriteLine();
        }

        //write a recursive method to reverse a string
        private static string Reverso(string msg, int index)
        {
            //what is the exit condition?
            if(index == msg.Length-1)
                return msg[msg.Length-1].ToString();

            return Reverso(msg, index+1) + msg[index].ToString();
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
