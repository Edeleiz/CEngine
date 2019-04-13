using System;
using System.Collections.Generic;
using CEngine.Interfaces.Effects;
using CEngine.Interfaces.Objects;
using CEngine.Interfaces.Stats;

namespace CEngine.Core.Effects
{
    public class EffectController : IEffectController
    {
        public List<IEffect> Effects { get; }
        public IGameObject Owner { get; }

        public EffectController(IGameObject owner)
        {
            Owner = owner ?? throw new ArgumentNullException(nameof(owner));
            Effects = new List<IEffect>();
        }
        
        public virtual void ApplyEffect(IEffect effect)
        {
            foreach (var modifier in effect.Modifiers)
            {
                var stats = Owner.GetStats(modifier.StatType);
                stats.ApplyModifier(modifier);
            }
            
            Effects.Add(effect);
        }

        public virtual void RemoveEffect(IEffect effect)
        {
            if (!Effects.Contains(effect))
            {
                return;
            }
            
            foreach (var modifier in effect.Modifiers)
            {
                var stats = Owner.GetStats(modifier.StatType);
                stats.RemoveModifier(modifier);
            }

            Effects.Remove(effect);
        }
    }
}