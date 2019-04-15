using System;
using System.Collections.Generic;

namespace CEngine.Interfaces.Objects
{
    public interface IHealthController
    {
        float CurrentHealth { get; }
        float MaxHealth { get; }
        
        float ApplyDamage(float damage, object damageType);
        IResist GetResist(object type);
    }

    public interface IHealthController<in T> : IHealthController where T : Enum
    {
        float ApplyDamage(float damage, T damageType);
        IResist<TK> GetResist<TK>() where TK : Enum;
    }
}