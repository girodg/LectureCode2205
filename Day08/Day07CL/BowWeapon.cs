using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class BowWeapon : FantasyWeapon
    {
        public int ArrowCapacity { get; set; }
        public int ArrowCount { get; set; }

        public BowWeapon(int capacity, int count, WeaponRarity rarity, int lvl, int maxDamage, int cost)
            : base(rarity, lvl, maxDamage, cost)
        {
            ArrowCapacity = capacity;
            ArrowCount = count;
        }
    }
}
