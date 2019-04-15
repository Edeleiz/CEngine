using System;
using System.Collections.Generic;
using CEngine.Interfaces.Stats;

namespace CEngine.Core.Stats
{
    public class Stats<T> : IStats<T> where T : Enum
    {
        public Stats()
        {
            List = new List<IStat>();
        }
        private List<IStat> List { get; }

        public T Type { get; }

        Enum IStats.Type => Type;

        public void ApplyModifier(IModifier modifier)
        {
            throw new NotImplementedException();
        }

        public void ApplyModifiers(List<IModifier> modifiers)
        {
            throw new NotImplementedException();
        }

        public void RemoveModifier(IModifier modifier)
        {
            throw new NotImplementedException();
        }

        public void RemoveModifiers(IModifier modifier)
        {
            throw new NotImplementedException();
        }

        public IStat GetStat(Enum type)
        {
            return GetStat((T) type);
        }

        public void AddStat(IStat stat)
        {
            throw new NotImplementedException();
        }

        public void ApplyModifier(IModifier<T> modifier)
        {
            throw new NotImplementedException();
        }

        public void ApplyModifiers(List<IModifier<T>> modifiers)
        {
            throw new NotImplementedException();
        }

        public void RemoveModifier(IModifier<T> modifier)
        {
            throw new NotImplementedException();
        }

        public void RemoveModifiers(IModifier<T> modifier)
        {
            throw new NotImplementedException();
        }

        public IStat GetStat(T type)
        {
            foreach (var stat in List)
            {
                if (Equals(stat.Type, type))
                {
                    return stat;
                }
            }

            return null;
        }

        public IStat<TK, T> GetStat<TK>(T type)
        {
            return (IStat<TK, T>) GetStat(type);
        }
    }
}