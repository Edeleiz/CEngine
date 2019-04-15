using CEngine.Interfaces.Objects;
using CEngine.Interfaces.Objects.Units;

namespace CEngine.Core.Objects
{
    public class Unit : GameObject, IUnit
    {
        protected Unit()
        {
            
        }
        
        public IHealthController HealthController { get; }
    }
}