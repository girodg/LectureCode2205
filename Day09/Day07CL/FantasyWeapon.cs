using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class FantasyWeapon
    {
        public static int NumberOfWeapons { get; private set; } = 0;

        public WeaponRarity Rarity { get; set; } = WeaponRarity.Common;
        public int Level { get; set; }
        public int MaxDamage { get; set; }
        public int Cost { get; set; }

        public FantasyWeapon(WeaponRarity rarity, int lvl, int maxDamage, int cost)
        {
            Rarity = rarity;
            Level = lvl;
            MaxDamage = maxDamage;
            Cost = cost;

            NumberOfWeapons++;
        }

        //an instance method (non-static)
        //instance methods have a hidden parameter called 'this'
        public int DoDamage()//FantasyWeapon this
        {
            Random randy = new Random();
            return (int)(this.MaxDamage * randy.NextDouble());
        }

        public virtual void Display()
        {
            Console.WriteLine($"I have a {Rarity} Level {Level} weapon that can do {MaxDamage} of damage. It costs {Cost} gold!");

        }
    }
}
