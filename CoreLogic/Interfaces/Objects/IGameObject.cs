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
        List<IStatController> Stats { get; }
        IEffectController EffectController { get; }
        
        IStatController<T> GetStats<T>() where T : Enum;
        IStatController GetStats(Enum type);
    }
}