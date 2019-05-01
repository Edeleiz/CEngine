using System;
using System.Collections.Generic;
using System.Linq;
using CEngine.Core.Stats;
using CEngine.Interfaces.Objects.Components;
using CEngine.Interfaces.Resists;
using CEngine.Interfaces.Stats;

namespace CEngine.Core.Objects
{
    /// <summary>
    /// Health stat types
    /// </summary>
    public enum HealthStatType
    {
        MaxHealth
    }
    
    /// <summary>
    /// Controls objects HP, receives damage and applies resisits
    /// </summary>
    /// <typeparam name="T">Damage type enum for resists</typeparam>
    public class HealthController<T> : IHealthController<T, HealthStatType> where T : Enum
    {
        IStatController IHealthController.StatController => StatController;

        /// <summary>
        /// Current health. Can not be greater than Max Health
        /// </summary>
        public float CurrentHealth { get; private set; }

        public float MaxHealth => StatController.GetStat<float>(HealthStatType.MaxHealth).Value;

        private List<IResist<T>> Resists { get; }
        public IStatController<HealthStatType> StatController { get; } 

        public HealthController(float baseHp = 1)
        {
            Resists = new List<IResist<T>>();
            StatController = new StatController<HealthStatType>();
            StatController.AddStat(new MaxHealthTypedStat(baseHp));
            CurrentHealth = MaxHealth;
            StatController.OnStatChange += OnStatChange;
        }

        public float ApplyDamage(float damage, object damageType)
        {
            if (damageType.GetType() != typeof(T))
            {
                return damage;
            }

            return ApplyDamage(damage, (T) damageType);
        }

        public List<IResist> GetResists(object type)
        {
            if (type.GetType() != typeof(T))
            {
                return new List<IResist>();
            }

            return new List<IResist>(Resists);
        }

        public void AddResist(IResist resist)
        {
            if (resist.Type.GetType() != typeof(T))
            {
                return;
            }
            AddResist((IResist<T>) resist);
        }

        public float ApplyDamage(float damage, T damageType)
        {
            var finalDamage = CalculatePiercingDamage(damage, damageType);
            CurrentHealth -= finalDamage;
            return finalDamage;
        }

        public List<IResist<T>> GetResists(T type)
        {
            var result = new List<IResist<T>>();
            foreach (var resist in Resists)
            {
                if (Equals(resist.Type, type))
                {
                    result.Add(resist);
                }
            }

            return result;
        }

        public void AddResist(IResist<T> resist)
        {
            Resists.Add(resist);
        }

        private float CalculatePiercingDamage(float damage, T damageType)
        {
            var resists = GetResists(damageType);
            if (resists.Count == 0)
            {
                return damage;
            }

            var sortedList = resists.OrderBy(resist => resist.Priority);
            var finalDamage = sortedList.Aggregate(damage, (current, resist) => resist.Reduce(current));
            return finalDamage;
        }

        private void OnStatChange(IStat stat)
        {
            var typedStat = stat.ToStatType<float, HealthStatType>();
            switch (typedStat.Type)
            {
                case HealthStatType.MaxHealth:
                    OnMaxHealthUpdate(typedStat.Value);
                    break;
            }
        }

        private void OnMaxHealthUpdate(float value)
        {
            if (Math.Abs(CurrentHealth - MaxHealth) < 0.0001f)
            {
                CurrentHealth = MaxHealth;
            }
        }

        public override string ToString()
        {
            return CurrentHealth + "/" + MaxHealth;
        }
    }
}