using System;
using CEngine.Core.Stats;

namespace CGame.Game.Stats
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