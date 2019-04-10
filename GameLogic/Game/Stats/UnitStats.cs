using CEngine.Core.Stats;

namespace CGame.Game.Stats
{
    /// <inheritdoc />
    public class AttackStat : FloatStat<StatType>
    {
        public AttackStat(float value) : base(StatType.Attack.ToString(), value, StatType.Attack) {} 
    }

    /// <inheritdoc />
    public class HealthStat : FloatStat<StatType>
    {
        public HealthStat(float value) : base(StatType.Health.ToString(), value, StatType.Health) {}  
    }
}