using CEngine.Core.Stats;

namespace CEngine.Game.Stats
{
    /// <inheritdoc />
    public class AttackStat : BaseStat<float, StatType>
    {
        public AttackStat(float value) : base(StatType.Attack.ToString(), value, StatType.Attack)
        {
            _addValues = (val, mod) => val + mod;
        }  
    }

    /// <inheritdoc />
    public class HealthStat : BaseStat<float, StatType>
    {
        public HealthStat(float value) : base(StatType.Health.ToString(), value, StatType.Health)
        {
            _addValues = (val, mod) => val + mod;
        }  
    }

    static class ModifyFunctions
    {
        private static void AddFloat(float value, float modifier)
        {
            
        }
    }
}