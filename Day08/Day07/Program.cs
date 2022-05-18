using Day07CL;
using System;
using System.Collections.Generic;

namespace Day07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount acct = new BankAccount("Bank of Garrett", 12345, 67890, 10000);
            //acct is an instance of a BankAccount
            BankAccount savings = Factory.AccountCreator("BoG", 54321, 09876, 1000);

            //set my routing #
            acct.RoutingNumber = 12345;//calls the set automatically for me
            //'value' will be 12345 in the setter

            int routing = acct.RoutingNumber;//calls the get automatically for me
            Console.WriteLine(routing);

            Inventory hiking = new Inventory(3, new List<string>());
            Inventory backpack = new Inventory(3, new List<string>());
            backpack.AddItem("map");
            backpack.AddItem("pickaxe");
            backpack.AddItem("diamond sword");
            try
            {
                backpack.AddItem("parachute");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            FantasyWeapon sting = new FantasyWeapon(WeaponRarity.Legendary, 100, 1000, 100000);
            int damage = sting.DoDamage();
            Console.WriteLine($"We swing sting and do {damage} damage to the rat.");

            FantasyWeapon sword = Factory.CreateWeapon(WeaponRarity.Common, 1, 20, 10);
            damage = sword.DoDamage();

            Console.WriteLine($"# of weapons made: {FantasyWeapon.NumberOfWeapons}");
        }
    }
}
