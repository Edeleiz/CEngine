using System;
using System.Collections.Generic;
using CEngine.Core.Stats;
using CEngine.Interfaces.Objects;
using CEngine.Interfaces.Stats;

namespace CEngine.Core.Objects
{
    public enum HealthStatType
    {
        MaxHealth
    }
    
    public class HealthController<T> : IHealthController<T> where T : Enum
    {
        public float CurrentHealth { get; }

        public float MaxHealth => Stats.GetStat<float>(HealthStatType.MaxHealth).Value;

        private List<IResist<T>> Resists { get; }
        private IStats<HealthStatType> Stats { get; } 

        protected HealthController()
        {
            Resists = new List<IResist<T>>();
            Stats = new Stats<HealthStatType>();
        }

        public IResist GetResist(object type)
        {
            throw new NotImplementedException();
        }

        public IResist<TK> GetResist<TK>() where TK : Enum
        {
            throw new NotImplementedException();
        }

        public float ApplyDamage(float damage, object damageType)
        {
            throw new NotImplementedException();
        }

        public float ApplyDamage(float damage, T damageType)
        {
            throw new NotImplementedException();
        }
    }
}