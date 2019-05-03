using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CEngine.Interfaces.Effects;
using CEngine.Interfaces.Stats;

namespace CEngine.Interfaces.Objects
{
    
    public interface IGameObject
    {
        int X { get; set; }
        int Y { get; set; }
        OwnerType OwnerType { get; }
        IOwner Owner { get; }
        IEffectController EffectController { get; }
        
        IStatController<T> GetStats<T>() where T : Enum;
        IStatController GetStats(Type type);

        IList<IStatController> GetStatsList();
    }
}