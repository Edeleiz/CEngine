using System;

namespace CEngine.Core.Stats
{
    public class FloatStat<T> : BaseStat<float, T> where T : Enum
    {
        protected FloatStat(string name, float value, T type) : base(name, value, type)
        {
            AddValues = (val, mod) => val + mod;
        }
    }
}