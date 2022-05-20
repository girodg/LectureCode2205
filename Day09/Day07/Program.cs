using Day07CL;
using System;
using System.Collections.Generic;
using System.Linq;

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

            Inventory hiking = new Inventory(3, new List<FantasyWeapon>());
            Inventory backpack = new Inventory(3, new List<FantasyWeapon>());
            //backpack.AddItem("map");
            //backpack.AddItem("pickaxe");
            //backpack.AddItem("diamond sword");
            //try
            //{
            //    backpack.AddItem("parachute");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            FantasyWeapon sting = new FantasyWeapon(WeaponRarity.Legendary, 100, 1000, 100000);
            int damage = sting.DoDamage(100);
            Console.WriteLine($"We swing sting and do {damage} damage to the rat.");

            FantasyWeapon sword = Factory.CreateWeapon(WeaponRarity.Common, 1, 20, 10);
            damage = sword.DoDamage();

            BowWeapon bow = new BowWeapon(15, 5, WeaponRarity.Common, 5, 20, 20);

            backpack.AddItem(sting);
            backpack.AddItem(sword);
            backpack.AddItem(bow);
            backpack.PrintInventory();
            List<BowWeapon> myBows = backpack.Bows();
            List<BowWeapon> otherBows = myBows.ToList();

            Console.WriteLine($"# of weapons made: {FantasyWeapon.NumberOfWeapons}");

            Person alfred = new Person("Alfred Pennyworth", 85);
            Superhero batman = new Superhero("Bruce Wayne", 35, Superpower.Money, "Batman");

            int num = 5;
            double dNum = num;//implicit casting
            num = (int)dNum;//explicit cast

            //UPCASTING:
            //go from a derived type (Superhero) to a base type (Person)
            //ALWAYS safe
            Person bruce = batman;//does NOT create a new object
            //bruce = alfred;

            //DOWNCASTING:
            //go from a base type (Person) to a derived type (Superhero)
            //NOT SAFE!!!!!
            //3 ways to downcast
            //1) explicitly cast it
            try
            {
                Superhero hero = (Superhero)alfred;
            }
            catch (Exception)
            {
            }

            //2) use the 'as' keyword
            //will assign null to super if alfred is NOT a superhero
            Superhero super = alfred as Superhero;
            if(super != null)
                Console.WriteLine(super.Identity);

            //3) use pattern matching
            if (alfred is Superhero hero2)
                Console.WriteLine(hero2.Identity);

            List<Person> people = new List<Person>();
            people.Add(alfred);
            people.Add(batman);
            people.Add(new Superhero("Arthur Curry", 30, Superpower.Strength, "Aquaman"));

            foreach (Person person in people)
            {
                person.WhoAmI();
                //Console.WriteLine(person);
            }
        }
    }
}
