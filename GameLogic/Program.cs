using System;
using CEngine.Game.Stats;
using CEngine.Interfaces.Stats;

namespace CEngine
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var stat = new AttackStat(5.0f);
            var mod = new AttackModifier(1.0f);
            var mod2 = new AttackModifier(-3.0f);
            var mod3 = new AttackModifier(13.0f);
            stat.AddModifier(mod);
            stat.AddModifier(mod2);
            stat.AddModifier(mod3);
            Console.Write(stat.ModifiedValue);
            var inter = (IStat) stat;
            Console.Write(inter.ModifiedValue);
        }
    }
}