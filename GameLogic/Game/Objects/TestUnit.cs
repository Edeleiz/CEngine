using System;
using CEngine.Core.Objects;
using CGame.Core.Enum;
using CGame.Core.Objects;
using CGame.Core.Resists;

namespace CGame.Game.Objects
{
    public class TestUnit : BaseUnit
    {
        public TestUnit()
        {
        }

        public void DebugInfo()
        {
            Console.Write("\n");
            Console.Write(HealthController.MaxHealth);
            Console.Write("\n");
            Console.Write(HealthController.CurrentHealth);
        }

        protected override void InitHealthController(float baseHp)
        {
            HealthController = new HealthController<DamageType>(500);
            HealthController.AddResist(new ArmorResist(0.43f));
        }

        protected override BaseUnitProperties GetProps(BaseUnitProperties props)
        {
            props.BaseHp = 500;
            return props;
        }
    }
}