using System;
using CEngine.Interfaces.Objects.Components;

namespace CEngine.Interfaces.Objects.Units
{
    public interface IUnit<T, TK> : IGameObject, IDamageable<T, TK> where TK : Enum where T : Enum
    {
        
    }
}