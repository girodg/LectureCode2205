using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public static class Factory
    {
        public static BankAccount AccountCreator(string bank, int routing, int acctNum, double balance)
        {
            return new BankAccount(bank, routing, acctNum, balance);
        }

        public static FantasyWeapon CreateWeapon(WeaponRarity rarity, int lvl, int maxDamage, int cost)
        {
            return new FantasyWeapon(rarity, lvl, maxDamage, cost);
        }
    }
}
