using System;

namespace CEngine.Interfaces.Objects.Components
{
    public interface IDamageable
    {
        IHealthController HealthController { get; }
    }
    
    public interface IDamageable<T, TK> where TK : Enum where T : Enum
    {
        IHealthController<T, TK> HealthController { get; }
    }
}