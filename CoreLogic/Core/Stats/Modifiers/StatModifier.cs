using System;
using CEngine.Interfaces.Stats;

namespace CEngine.Core.Stats
{
    public abstract class StatModifier <T, TK> : IModifier<T, TK> where TK : Enum
    {
        protected StatModifier(T value, TK statType, ModifierType type, ModifierApplyType applyType)
        {
            Value = value;
            Type = type;
            ApplyType = applyType;
            StatType = statType;
        }
        
        public TK StatType { get; }
        Enum IModifier.StatType => StatType;

        public ModifierType Type { get; }
        public ModifierApplyType ApplyType { get; }
        public T Value { get; }
        object IModifier.Value => Value;
    }
}