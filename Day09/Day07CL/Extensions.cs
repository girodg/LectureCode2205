using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public static class Extensions
    {
        public static List<BowWeapon> Bows(this Inventory inv)
        {
            List<BowWeapon> bows = new();
            foreach (var item in inv.Items)
            {
                if (item is BowWeapon bow)
                    bows.Add(bow);
            }
            return bows;
        }
    }
}
