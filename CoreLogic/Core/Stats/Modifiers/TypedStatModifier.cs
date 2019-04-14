using System;
using CEngine.Interfaces.Stats;

namespace CEngine.Core.Stats
{
    public class TypedStatModifier<T, TK, TM> : StatModifier<T, TK>, ITypedModifier<TM> where TK : Enum where TM : Enum
    {
        public TypedStatModifier(T value, 
            TK statType, 
            ModifierApplyType applyType, 
            ModifierDurationType durationType,
            TM modifierType) 
            : base(value, statType, applyType, durationType)
        {
            ModifierType = modifierType;
        }

        public new TM ModifierType { get; }
        Enum IModifier.ModifierType => ModifierType;
    }
}