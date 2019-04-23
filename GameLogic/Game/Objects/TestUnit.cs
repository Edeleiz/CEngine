using System;
using CEngine.Core.Objects;
using CGame.Game.Resists;

namespace CGame.Game.Objects
{
    public class TestUnit : Unit<DamageType>
    {
        public TestUnit()
        {
            HealthController = new HealthController<DamageType>(500);
            HealthController.AddResist(new ArmorResist(0.43f));
        }

        public void DebugInfo()
        {
            Console.Write("\n");
            Console.Write(HealthController.MaxHealth);
            Console.Write("\n");
            Console.Write(HealthController.CurrentHealth);
        }
    }
}