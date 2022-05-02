using System;

namespace Day01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 5, n2 = 2;
            int sum = Add(n1, n2);
            PrintMessage();
            string msg = GetMessage();
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

        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

    }
}
