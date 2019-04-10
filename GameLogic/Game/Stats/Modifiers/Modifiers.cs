using CEngine.Core.Stats;
using CEngine.Interfaces.Stats;

namespace CEngine.Game.Stats
{
    public class AttackModifier : StatModifier<float, StatType>
    {
        public AttackModifier(float value) : base(value, StatType.Attack, ModifierType.Relative) { }
    }
    
    public class HealthModifier : StatModifier<float, StatType>
    {
        public HealthModifier(float value) : base(value, StatType.Health, ModifierType.Relative) { }
    }
}