using System;
using System.Collections.Generic;
using CEngine.Interfaces.Stats;

namespace CEngine.Interfaces.Effects
{
    public interface IEffect
    {
        List<IModifier> Modifiers { get; }
    }

    public interface IEffect<out T> : IEffect where T : Enum
    {
        T Type { get; }
    }
}