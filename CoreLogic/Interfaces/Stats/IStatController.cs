using System;
using System.Collections.Generic;

namespace CEngine.Interfaces.Stats
{
    public interface IStatController
    {
        Action<IStat> OnStatChange { get; set; }
        Type StatType { get; }
        void ApplyModifier(IModifier modifier);
        void ApplyModifiers(List<IModifier> modifiers);
        void RemoveModifier(IModifier modifier);
        void RemoveModifiers(IModifier modifier);
        IStat GetStat(Enum type);
        void AddStat(IStat stat);
    }
    
    public interface IStatController<T> : IStatController where T : Enum
    {
        void ApplyModifier(IModifier<T> modifier);
        void ApplyModifiers(List<IModifier<T>> modifiers);
        void RemoveModifier(IModifier<T> modifier);
        void RemoveModifiers(IModifier<T> modifier);
        IStat<T> GetStat(T type);
        ITypedStat<TK, T> GetStat<TK>(T type);
        void AddStat(IStat<T> stat);
    }
}