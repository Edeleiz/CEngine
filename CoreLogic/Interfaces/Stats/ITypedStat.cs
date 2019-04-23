using System;
using System.Collections.Generic;

namespace CEngine.Interfaces.Stats
{
    /// <summary>
    /// Base interface for unit's stats.
    /// </summary>
    public interface IStat
    {
        Enum Type { get; }
        
        /// <summary>
        /// Stat's unique name
        /// </summary>
        string Name { get; }
        
        /// <summary>
        /// Stat initial value
        /// </summary>
        object Value { get; }
        
        /// <summary>
        /// The result of applying mods to the initial value
        /// </summary>
        object ModifiedValue { get; }
        
        /// <summary>
        /// Modifiers attached to the stat
        /// </summary>
        List<IModifier> Modifiers { get; }

        IStat<TS> ToStatType<TS>() where TS : Enum;
        ITypedStat<T, TS> ToStatType<T, TS>() where TS : Enum;

        void AddModifier(IModifier modifier);
        void RemoveModifier(IModifier modifier);
    }

    /// <inheritdoc />
    /// <typeparam name="T">Enum used for defining different stat types</typeparam>
    public interface IStat<out T> : IStat where T : Enum
    {
        new T Type { get; }
    }

    /// <inheritdoc />
    /// <summary>
    /// Typed base interface for unit's stats.
    /// </summary>
    /// <typeparam name="T">Variable type of the stat</typeparam>
    /// <typeparam name="TK">Enum used for defining different stat types</typeparam>
    public interface ITypedStat<T, TK> : IStat<TK> where TK : Enum
    {
        new T Value { get; }
        new T ModifiedValue { get; }
        new List<IModifier<T, TK>> Modifiers { get; }
    }
}