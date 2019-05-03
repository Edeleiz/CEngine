using CEngine.Core.Objects;
using CGame.Core.Resists;
using DamageType = CGame.Core.Enum.DamageType;

namespace CGame.Core.Objects
{
    public abstract class BaseUnit : Unit<DamageType>, IUpdatable
    {
        public virtual void Update(float timePassed)
        {
            
        }
    }
}