using System;
using System.Collections.Generic;

namespace CEngine.Interfaces.Stats
{
    /// <summary>
    /// Base interface for unit's stats.
    /// </summary>
    public interface IStat
    {
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

        void AddModifier(IModifier modifier);
        void RemoveModifier(IModifier modifier);
    }

    /// <inheritdoc />
    /// <summary>
    /// Typed base interface for unit's stats.
    /// </summary>
    /// <typeparam name="T">Variable type of the stat</typeparam>
    /// <typeparam name="TK">Enum used for defining different stat types</typeparam>
    public interface IStat<T, TK> : IStat where TK : Enum
    {
        new T Value { get; }
        new T ModifiedValue { get; }
        TK Type { get; }
        new List<IModifier<T, TK>> Modifiers { get; }
    }
}