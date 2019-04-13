using System;

namespace CEngine.Interfaces.Stats
{
    public enum ModifierType
    {
        Relative,
        Absolute
    }

    public enum ModifierApplyType
    {
        Temporary,
        Constant
    }
    
    public interface IModifier
    {
        Enum StatType { get; }
        ModifierType Type { get; }
        ModifierApplyType ApplyType { get; }
        object Value { get; }
    }

    public interface IModifier<out T> : IModifier where T : Enum
    {
        new T StatType { get; }
    }

    public interface IModifier<out T, out TK> : IModifier<TK> where TK : Enum
    {
        new T Value { get; }
    }
}