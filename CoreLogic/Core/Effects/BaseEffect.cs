using System.Collections.Generic;
using CEngine.Interfaces.Effects;
using CEngine.Interfaces.Stats;

namespace CEngine.Core.Effects
{
    public class BaseEffect : IEffect
    {
        protected BaseEffect()
        {
            Modifiers = new List<IModifier>();
        }
        
        public List<IModifier> Modifiers { get; }

        protected void AddModifier(IModifier modifier)
        {
            Modifiers.Add(modifier);
        }
    }
}