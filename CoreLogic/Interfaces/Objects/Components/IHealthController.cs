using System;
using System.Collections.Generic;
using CEngine.Core.Objects;
using CEngine.Interfaces.Resists;
using CEngine.Interfaces.Stats;

namespace CEngine.Interfaces.Objects.Components
{
    public enum HealthStatus
    {
        FullHp,
        ZeroHp,
        Damaged
    }
    
    public interface IHealthController : IDamageable, IResistible
    {
        Action<HealthStatus> OnStatusChange { get; set; }
        
        IStatController StatController { get; }
        
        HealthStatus CurrentStatus { get; }
    }

    public interface IHealthController<T, TK> : IHealthController, IDamageable<T>, IResistible<T> where T : Enum where TK : Enum
    {
        new IStatController<TK> StatController { get; } 
    }
}