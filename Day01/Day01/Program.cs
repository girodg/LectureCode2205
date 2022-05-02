using System;

namespace Day01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 5, n2 = 2;
            int sum = Add(n1, n2);

            //$ - interpolated string
            Console.Write($"{n1} * 3 = ");
            Factor(ref n1, 3);
            Console.WriteLine(n1);

            Console.WriteLine(DateTime.Now);

            PrintMessage();
            string msg = GetMessage();
            PrintMessage(msg);
        }

        static void Factor(ref int num1, int theFactor)
        {
            num1 *= theFactor;
        }

        static int Add(int num1, int num2)
        {
            num1++;
            return num1 + num2;
        }
        static string GetMessage()
        {
            Console.Write("What would you like to say? ");
            string usersInput = Console.ReadLine();
            return usersInput;
        }

        static void PrintMessage()
        {
            Console.WriteLine("Hello Gotham. I am the hero you need!");
        }

        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }


    }
}
