using System;
using CEngine.Interfaces.Stats;

namespace CEngine.Core.Resists
{
    public abstract class BaseAbsoluteResist<T> : BaseResist<T> where T : Enum
    {
        protected BaseAbsoluteResist(float value, int priority, T type, IStat baseStat = null) 
            : base(value, priority, type, baseStat)
        {
        }

        public override float Reduce(float damage)
        {
            return damage - Value;
        }
    }
}