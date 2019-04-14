using System;
using CEngine.Interfaces.Stats;

namespace CEngine.Core.Stats
{
    public abstract class StatModifier <T, TK> : IModifier<T, TK> where TK : Enum
    {
        protected StatModifier(T value, TK statType, ModifierApplyType applyType, ModifierDurationType durationType)
        {
            Value = value;
            ApplyType = applyType;
            DurationType = durationType;
            StatType = statType;
        }
        
        public TK StatType { get; }
        public virtual Enum ModifierType { get; }
        Enum IModifier.StatType => StatType;

        public ModifierApplyType ApplyType { get; }
        public ModifierDurationType DurationType { get; }
        public T Value { get; }
        object IModifier.Value => Value;
    }
}