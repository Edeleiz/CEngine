using System;
using System.Collections.Generic;
using CEngine.Interfaces.Stats;

namespace CEngine.Core.Stats
{
    public class StatController<T> : IStatController<T> where T : Enum
    {
        public StatController()
        {
            List = new List<IStat<T>>();
            StatType = typeof(T);
        }
        private List<IStat<T>> List { get; }

        public Action<IStat> OnStatChange { get; set; }

        public Type StatType { get; }

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
            if (stat.Type.GetType() != typeof(T))
            {
                return;
            }
            
            AddStat((IStat<T>) stat);
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

        public IStat<T> GetStat(T type)
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

        public ITypedStat<TK, T> GetStat<TK>(T type)
        {
            return (ITypedStat<TK, T>) GetStat(type);
        }

        public void AddStat(IStat<T> stat)
        {
            List.Add(stat);
        }
    }
}