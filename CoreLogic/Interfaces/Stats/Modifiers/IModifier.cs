using System;

namespace CEngine.Interfaces.Stats
{
    public enum ModifierApplyType
    {
        Relative,
        Absolute
    }

    public enum ModifierDurationType
    {
        Temporary,
        Constant
    }
    
    public interface IModifier
    {
        Enum StatType { get; }
        Enum ModifierType { get; }
        ModifierApplyType ApplyType { get; }
        ModifierDurationType DurationType { get; }
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

    public interface ITypedModifier<out T> : IModifier where T : Enum
    {
        new T ModifierType { get; }
    }
}