using System.Collections.Generic;
using CEngine.Interfaces.Objects;

namespace CEngine.Interfaces.Effects
{
    public interface IEffectController
    {
        List<IEffect> Effects { get; }
        IGameObject Owner { get; }

        void ApplyEffect(IEffect effect);
        void RemoveEffect(IEffect effect);
    }
}