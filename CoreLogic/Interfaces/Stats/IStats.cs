using System;
using System.Collections.Generic;

namespace CEngine.Interfaces.Stats
{
    public interface IStats
    {
        Enum Type { get; }
        void ApplyModifier(IModifier modifier);
        void ApplyModifiers(List<IModifier> modifiers);
        void RemoveModifier(IModifier modifier);
        void RemoveModifiers(IModifier modifier);
        IStat GetStat(Enum type);
        void AddStat(IStat stat);
    }
    
    public interface IStats<T> : IStats where T : Enum
    {
        new T Type { get; }
        void ApplyModifier(IModifier<T> modifier);
        void ApplyModifiers(List<IModifier<T>> modifiers);
        void RemoveModifier(IModifier<T> modifier);
        void RemoveModifiers(IModifier<T> modifier);
        IStat GetStat(T type);
        IStat<TK, T> GetStat<TK>(T type);
    }
}