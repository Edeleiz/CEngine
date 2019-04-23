using CEngine.Core.Objects;

namespace CEngine.Core.Stats
{
    public class MaxHealthTypedStat : FloatTypedStat<HealthStatType>
    {
        public MaxHealthTypedStat(float value) : base(HealthStatType.MaxHealth.ToString(), value, HealthStatType.MaxHealth){}
    }
}