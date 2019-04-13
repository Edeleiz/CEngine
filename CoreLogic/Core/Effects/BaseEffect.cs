using System.Collections.Generic;
using CEngine.Interfaces.Effects;
using CEngine.Interfaces.Stats;

namespace CEngine.Core.Effects
{
    public class BaseEffect : IEffect
    {
        public List<IModifier> Modifiers { get; }
    }
}