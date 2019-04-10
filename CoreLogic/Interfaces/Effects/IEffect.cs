using System.Collections.Generic;
using CEngine.Interfaces.Stats;

namespace CEngine.Interfaces.Effects
{
    public interface IEffect
    {
        List<IModifier> Modifiers { get; }
    }
}