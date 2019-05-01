using CEngine.Core.Stats;
using CEngine.Interfaces.Stats;

namespace CGame.Core.Stats
{
    public enum ModifierType
    {
        PhysicalDamage,
        PureDamage
    }
    
    public class AttackModifier : StatModifier<float, StatType>
    {
        public AttackModifier(float value) : base(value, StatType.Attack, ModifierApplyType.Relative, ModifierDurationType.Temporary) { }
    }
    
    public class HealthModifier : StatModifier<float, StatType>
    {
        public HealthModifier(float value) : base(value, StatType.Health, ModifierApplyType.Relative, ModifierDurationType.Temporary) { }
    }
    
    public class DamageModifier : TypedStatModifier<float, UnitStatType, ModifierType>
    {
        public DamageModifier(float value) : base(value, 
                UnitStatType.CurrentHealth, 
                ModifierApplyType.Relative, 
                ModifierDurationType.Temporary,
                ModifierType.PhysicalDamage) { }
    }
}