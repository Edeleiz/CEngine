using System;
using CEngine.Interfaces.Objects;
using CEngine.Interfaces.Objects.Components;
using CEngine.Interfaces.Objects.Units;

namespace CEngine.Core.Objects
{
    public struct BaseUnitProperties
    {
        public float BaseHp;
    }
    
    public abstract class Unit<T> : GameObject, IUnit<T> where T : Enum
    {
        protected Unit()
        {
            Initialize();
        }

        protected IHealthController<T, HealthStatType> HealthController { get; set; }

        public float CurrentHealth => HealthController.CurrentHealth;
        public float MaxHealth => HealthController.MaxHealth;
        
        public float ApplyDamage(float damage, object damageType)
        {
            return HealthController.ApplyDamage(damage, damageType);
        }
        
        public float ApplyDamage(float damage, T damageType)
        {
            return HealthController.ApplyDamage(damage, damageType);
        }

        protected void Initialize()
        {
            var props = GetProps(new BaseUnitProperties());
            InitHealthController(props.BaseHp); 
        }

        protected abstract void InitHealthController(float baseHp);

        protected abstract BaseUnitProperties GetProps(BaseUnitProperties props);

        public override string ToString()
        {
            return this.GetType().ToString() + "(" + HealthController.ToString() + ")";
        }
    }
}