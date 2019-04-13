using System;
using System.Collections.Generic;

namespace CEngine.Interfaces.Stats
{
    public interface IStats
    {
        Enum Type { get; }
        List<IStat> List { get; }
        void ApplyModifier(IModifier modifier);
        void ApplyModifiers(List<IModifier> modifiers);
        void RemoveModifier(IModifier modifier);
        void RemoveModifiers(IModifier modifier);
    }
    
    public interface IStats<T> : IStats where T : Enum
    {
        void ApplyModifier(IModifier<T> modifier);
        void ApplyModifiers(List<IModifier<T>> modifiers);
        void RemoveModifier(IModifier<T> modifier);
        void RemoveModifiers(IModifier<T> modifier);
    }
}