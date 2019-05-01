using CEngine.Core.Resists;

namespace CGame.Core.Resists
{
    public enum DamageType
    {
        Basic,
        Magical
    }

    public class ArmorResist : BasePercentageResist<DamageType>
    {
        public ArmorResist(float value = 0.25f) : base(value, 1, DamageType.Basic){}
    }
    
    public class MagicResist : BasePercentageResist<DamageType>
    {
        public MagicResist(float value = 0.25f) : base(value, 1, DamageType.Magical){}
    }
}