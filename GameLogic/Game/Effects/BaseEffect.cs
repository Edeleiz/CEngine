using System.Collections.Generic;
using CEngine.Interfaces.Effects;
using CEngine.Interfaces.Stats;

namespace CGame.Game.Effects
{
    public class BaseEffect : IEffect<EffectType>
    {
        public List<IModifier> Modifiers { get; }
        public EffectType Type { get; }
    }
}