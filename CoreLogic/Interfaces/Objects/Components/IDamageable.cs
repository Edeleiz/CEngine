using System;

namespace CEngine.Interfaces.Objects.Components
{
    public interface IDamageable
    {
        float CurrentHealth { get; }
        float MaxHealth { get; }
        
        float ApplyDamage(float damage, object damageType);
    }
    
    public interface IDamageable<in T> : IDamageable where T : Enum
    {
        float ApplyDamage(float damage, T damageType);
    }
}