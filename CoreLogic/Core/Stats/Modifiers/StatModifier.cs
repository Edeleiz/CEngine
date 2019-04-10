using System;
using CEngine.Interfaces.Stats;

namespace CEngine.Core.Stats
{
    public abstract class StatModifier <T, TK> : IModifier<T> where TK : Enum
    {
        protected StatModifier(T value, TK statType, ModifierType type)
        {
            Value = value;
            Type = type;
            StatType = statType;
        }
        
        public TK StatType { get; }

        public ModifierType Type { get; }
        public T Value { get; }
        object IModifier.Value => Value;
    }
}