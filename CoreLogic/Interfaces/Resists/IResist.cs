using System;
using CEngine.Interfaces.Stats;

namespace CEngine.Interfaces.Resists
{
    /// <summary>
    /// Resist against specific type of damage
    /// </summary>
    public interface IResist
    {
        /// <summary>
        /// Damage type. Should be set in Enum
        /// </summary>
        object Type { get; }
        
        /// <summary>
        /// Current resist
        /// </summary>
        float Value { get; }
        
        /// <summary>
        /// Stat on which resist is based. Can be null
        /// </summary>
        IStat BaseStat { get; }

        /// <summary>
        /// Applies reduction to the damage
        /// </summary>
        /// <param name="damage">Incoming damage</param>
        /// <returns>Damage after reduction</returns>
        float Reduce(float damage);
        
        int Priority { get; }
    }

    /// <inheritdoc />
    /// <summary>
    /// Resist against specific type of damage
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IResist<out T> : IResist where T : Enum
    {
        new T Type { get; }
    }
}