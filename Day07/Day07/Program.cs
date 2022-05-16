using Day07CL;
using System;

namespace Day07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount acct = new BankAccount("Bank of Garrett", 12345, 67890, 10000);

            //set my routing #
            acct.RoutingNumber = 12345;//calls the set automatically for me
            //'value' will be 12345 in the setter

            int routing = acct.RoutingNumber;//calls the get automatically for me
            Console.WriteLine(routing);
        }
    }
}
