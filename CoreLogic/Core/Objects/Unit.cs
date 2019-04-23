using System;
using CEngine.Interfaces.Objects;
using CEngine.Interfaces.Objects.Components;
using CEngine.Interfaces.Objects.Units;

namespace CEngine.Core.Objects
{
    public class Unit<T> : GameObject, IUnit<T, HealthStatType> where T : Enum
    {
        protected Unit()
        {
            
        }

        public IHealthController<T, HealthStatType> HealthController { get; protected set; }
    }
}