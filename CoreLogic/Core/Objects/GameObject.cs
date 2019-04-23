using System;
using System.Collections.Generic;
using CEngine.Core.Effects;
using CEngine.Interfaces.Effects;
using CEngine.Interfaces.Objects;
using CEngine.Interfaces.Stats;

namespace CEngine.Core.Objects
{
    public class GameObject : IGameObject
    {
        protected GameObject()
        {
            EffectController = new EffectController(this);
            Stats = new List<IStatController>();
        }
        
        public int X { get; set; }
        public int Y { get; set; }
        public List<IStatController> Stats { get; }
        public IEffectController EffectController { get; }
        
        public IStatController<T> GetStats<T>() where T : Enum
        {
            foreach (var statList in Stats)
            {
                if (statList is IStatController<T> list)
                {
                    return list;
                }
            }

            return null;
        }

        public IStatController GetStats(Enum type)
        {
            foreach (var statList in Stats)
            {
                if (Equals(statList.StatType, type))
                {
                    return statList;
                }
            }

            return null;
        }
    }
}