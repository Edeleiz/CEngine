using System;
using System.Collections.Generic;
using CEngine.Interfaces.Effects;
using CEngine.Interfaces.Stats;

namespace CEngine.Interfaces.Objects
{
    public interface IGameObject
    {
        int X { get; set; }
        int Y { get; set; }
        List<IStats> Stats { get; }
        IEffectController EffectController { get; }
        
        IStats<T> GetStats<T>() where T : Enum;
        IStats GetStats(Enum type);
    }
}