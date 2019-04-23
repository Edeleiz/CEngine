using System;
using CEngine.Interfaces.Resists;
using CEngine.Interfaces.Stats;

namespace CEngine.Core.Resists
{
    public abstract class BaseResist<T> : IResist<T> where T : Enum
    {
        protected BaseResist(float value, int priority, T type, IStat baseStat = null)
        {
            Value = value;
            Priority = priority;
            Type = type;
            BaseStat = baseStat;
        }
        
        object IResist.Type => Type;
        public T Type { get; }
        public float Value { get; }
        public int Priority { get; }
        public IStat BaseStat { get; }
        
        public abstract float Reduce(float damage);
    }
}