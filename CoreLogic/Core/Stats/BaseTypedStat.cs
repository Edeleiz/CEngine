using System;
using System.Collections.Generic;
using CEngine.Interfaces.Stats;

namespace CEngine.Core.Stats
{
    /// <inheritdoc />
    /// <summary>
    /// Base class for unit's stats. Should be overriden
    /// </summary>
    /// <typeparam name="T">Variable type of the stat</typeparam>
    /// <typeparam name="TK">Enum used for defining different stat types</typeparam>
    public abstract class BaseTypedStat<T, TK> : ITypedStat<T, TK> where TK : Enum
    {
        /// <summary>
        /// Function for adding stat value with modifier, where
        /// first argument is Value, second Modifier Value.
        /// Returns the product of adding.
        /// </summary>
        protected Func<T, T, T> AddValues;

        /// <summary>
        /// Initial setup of the stat
        /// </summary>
        /// <param name="name">Custom name for stat</param>
        /// <param name="value">Initial value</param>
        /// <param name="type">Type of stat in <typeparamref name="T"/></param>
        protected BaseTypedStat(string name, T value, TK type)
        {
            Modifiers = new List<IModifier<T, TK>>();
            Name = name;
            Value = value;
            ModifiedValue = Value;
            Type = type;
        }

        public string Name { get; }
        public T Value { get; }
        public T ModifiedValue { get; private set; }

        List<IModifier> IStat.Modifiers => GetModifiersWithoutType();

        public List<IModifier<T, TK>> Modifiers { get; }

        public TK Type { get; }

        Enum IStat.Type => Type;
        object IStat.Value => Value;
        object IStat.ModifiedValue => ModifiedValue;

        public void AddModifier(IModifier modifier)
        {
            if (modifier is StatModifier<T, TK> statModifier)
                AddModifier(statModifier);
        }
        
        public void AddModifier(StatModifier<T, TK> modifier)
        {
            if (!Equals(modifier.StatType, Type))
                return;
            Modifiers.Add(modifier);
            RecalculateModifiedValue();
        }
        
        public void RemoveModifier(IModifier modifier)
        {
            if (modifier is StatModifier<T, TK> statModifier)
                RemoveModifier(statModifier);
        }

        public void RemoveModifier(StatModifier<T, TK> modifier)
        {
            if (!Equals(modifier.StatType, Type))
                return;
            Modifiers.Remove(modifier);
            RecalculateModifiedValue();
        }

        protected virtual void RecalculateModifiedValue()
        {
            var result = Value;
            foreach (var modifier in Modifiers)
            {
                switch (modifier.ApplyType)
                {
                    case ModifierApplyType.Relative:
                        if (AddValues != null)
                            result = AddValues(result, modifier.Value);
                        break;
                    case ModifierApplyType.Absolute:
                        result = modifier.Value;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            ModifiedValue = result;
        }

        private List<IModifier> GetModifiersWithoutType(List<IModifier> result = null)
        {
            result = result ?? new List<IModifier>();
            foreach (var mod in Modifiers)
                result.Add(mod);
            return result;
        }
        
        public IStat<TS> ToStatType<TS>() where TS : Enum
        {
            if (typeof(TS) == typeof(TK))
            {
                return (IStat<TS>) this;
            }

            return null;
        }

        public ITypedStat<TT, TS> ToStatType<TT, TS>() where TS : Enum
        {
            if (typeof(TS) == typeof(TK) &&
                typeof(TT) == typeof(T))
            {
                return (ITypedStat<TT, TS>) this;
            }

            return null;
        }
    }
}