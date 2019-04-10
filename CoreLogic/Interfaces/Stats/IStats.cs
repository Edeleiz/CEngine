using System.Collections.Generic;

namespace CEngine.Interfaces.Stats
{
    public interface IStats
    {
        List<IStat> Stats { get; }
        List<IModifier> Modifiers { get; }
    }
}