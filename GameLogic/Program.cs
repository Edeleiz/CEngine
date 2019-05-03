using System;
using CEngine.Core.Objects;
using CEngine.Interfaces.Stats;
using CGame.Core.Enum;
using CGame.Core.Objects;
using CGame.Core.Resists;
using CGame.Core.Stats;
using CGame.Game.Main;
using CGame.Game.Objects;

namespace CGame
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var stat = new AttackTypedStat(5.0f);
            var mod = new AttackModifier(1.0f);
            var mod2 = new AttackModifier(-3.0f);
            var mod3 = new AttackModifier(13.0f);
            stat.AddModifier(mod);
            stat.AddModifier(mod2);
            stat.AddModifier(mod3);
            Console.Write(stat.ModifiedValue);
            var inter = (IStat) stat;
            Console.Write(inter.ModifiedValue);

            var unit = new TestUnit();
            unit.ApplyDamage(100f, DamageType.Basic);
            unit.DebugInfo();
            unit.ApplyDamage(100f, DamageType.Magical);
            unit.DebugInfo();
            Console.Write("\n");
            Console.Write(unit.ToString());

            var game = new StartupController();
        }
    }
}