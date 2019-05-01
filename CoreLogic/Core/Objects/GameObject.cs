using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CEngine.Core.Effects;
using CEngine.Interfaces.Effects;
using CEngine.Interfaces.Objects;
using CEngine.Interfaces.Stats;

namespace CEngine.Core.Objects
{
    public class GameObject : IGameObject
    {
        protected List<IStatController> _stats;
        
        protected GameObject()
        {
            EffectController = new EffectController(this);
            _stats = new List<IStatController>();
        }
        
        public int X { get; set; }
        public int Y { get; set; }

        public IEffectController EffectController { get; }
        
        public IStatController<T> GetStats<T>() where T : Enum
        {
            foreach (var statList in _stats)
            {
                if (statList is IStatController<T> list)
                {
                    return list;
                }
            }

            return null;
        }

        public IStatController GetStats(Type type)
        {
            foreach (var statList in _stats)
            {
                if (statList.StatType == type)
                {
                    return statList;
                }
            }

            return null;
        }

        public IList<IStatController> GetStatsList()
        {
            return _stats.AsReadOnly();
        }

        public virtual void Update(float timePassed)
        {
            
        }
    }
}