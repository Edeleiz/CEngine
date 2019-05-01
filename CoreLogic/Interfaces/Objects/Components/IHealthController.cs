using System;
using System.Collections.Generic;
using CEngine.Core.Objects;
using CEngine.Interfaces.Resists;
using CEngine.Interfaces.Stats;

namespace CEngine.Interfaces.Objects.Components
{
    public interface IHealthController : IDamageable, IResistible
    {
        IStatController StatController { get; }
    }

    public interface IHealthController<T, TK> : IHealthController, IDamageable<T>, IResistible<T> where T : Enum where TK : Enum
    {
        new IStatController<TK> StatController { get; } 
    }
}