using CEngine.Interfaces.Effects;
using CEngine.Interfaces.Objects;

namespace CEngine.Interfaces.Abilities
{
    public enum AbilityType
    {
        
    }
    
    public interface IAbility
    {
        AbilityType Type { get; }
        
        IGameObject Caster { get; }
        
        IEffect CasterEffect { get; }
        
        string Name { get; }
    }

    public interface ITargetAbility<out T> : IAbility
    {
        T Target { get; }
        
        IEffect TargetEffect { get; }
    }
}