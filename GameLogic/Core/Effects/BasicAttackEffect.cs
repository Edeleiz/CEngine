using CEngine.Core.Effects;
using CGame.Core.Stats;

namespace CGame.Core.Effects
{
    public class BasicAttackEffect : BaseEffect
    {
        public BasicAttackEffect(float value)
        {
            var damageMod = new DamageModifier(value);
            AddModifier(damageMod);
        }
    }
}