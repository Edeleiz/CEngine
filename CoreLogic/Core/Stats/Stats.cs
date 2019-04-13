using System;
using System.Collections.Generic;
using CEngine.Interfaces.Stats;

namespace CEngine.Core.Stats
{
    public class Stats<T> : IStats<T> where T : Enum
    {
        public Stats()
        {
            
        }
        
        public Enum Type { get; }
        public List<IStat> List { get; }
        
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
    }
}