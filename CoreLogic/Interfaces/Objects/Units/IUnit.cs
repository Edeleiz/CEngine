using System;
using CEngine.Interfaces.Objects.Components;

namespace CEngine.Interfaces.Objects.Units
{
    public interface IUnit<in T> : IGameObject, IDamageable<T> where T : Enum
    {
        
    }
}