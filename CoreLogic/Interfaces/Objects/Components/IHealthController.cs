using System;
using System.Collections.Generic;
using CEngine.Core.Objects;
using CEngine.Interfaces.Resists;
using CEngine.Interfaces.Stats;

namespace CEngine.Interfaces.Objects.Components
{
    public interface IHealthController : IResistible
    {
        IStatController StatController { get; } 
        float CurrentHealth { get; }
        float MaxHealth { get; }
        
        float ApplyDamage(float damage, object damageType);
    }

    public interface IHealthController<T, TK> : IHealthController, IResistible<T> where T : Enum where TK : Enum
    {
        float ApplyDamage(float damage, T damageType);
        new IStatController<TK> StatController { get; } 
    }
}