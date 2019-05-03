using CEngine.Core.Stats;
using CGame.Core.Enum;

namespace CGame.Core.Stats
{
    /// <inheritdoc />
    public class AttackTypedStat : FloatTypedStat<StatType>
    {
        public AttackTypedStat(float value) : base(StatType.Attack.ToString(), value, StatType.Attack) {}
    }

    /// <inheritdoc />
    public class HealthTypedStat : FloatTypedStat<StatType>
    {
        public HealthTypedStat(float value) : base(StatType.Health.ToString(), value, StatType.Health) {}
    }
}