using CEngine.Core.Objects;

namespace CEngine.Core.Stats
{
    public class MaxHealthStat : FloatStat<HealthStatType>
    {
        protected MaxHealthStat(string name, float value, HealthStatType type) : base(name, value, type){}
    }
}