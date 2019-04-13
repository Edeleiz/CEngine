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
            Stats = new List<IStats>();
        }
        
        public int X { get; set; }
        public int Y { get; set; }
        public List<IStats> Stats { get; }
        public IEffectController EffectController { get; }
        
        public IStats<T> GetStats<T>() where T : Enum
        {
            foreach (var statList in Stats)
            {
                if (statList is IStats<T> list)
                {
                    return list;
                }
            }

            return null;
        }

        public IStats GetStats(Enum type)
        {
            foreach (var statList in Stats)
            {
                if (Equals(statList.Type, type))
                {
                    return statList;
                }
            }

            return null;
        }
    }
}