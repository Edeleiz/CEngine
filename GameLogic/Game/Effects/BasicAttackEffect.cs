using CEngine.Core.Effects;
using CGame.Game.Stats;

namespace CGame.Game.Effects
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