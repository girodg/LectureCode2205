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
            //call a method to put a timestamp on the front of my message
            Timestamp(ref msg);
            string myNum = "Bob";
            bool isANumber = IntTryParse(myNum, out int myNumber);

            if (isANumber)  Console.WriteLine(myNumber);
            else            Console.WriteLine("NOT a number.");

            PrintMessage(msg);
        }

        static bool IntTryParse(string myNum, out int number)
        {
            try
            {
                number = int.Parse(myNum);//throw an exception IF myNum is not a number
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine($"{myNum} is not a number.");
                number = 0;
                return false;
            }        
        }

        static void Timestamp(ref string message)
        {
            message = $"{DateTime.Now}: {message}";
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
