using System;

namespace CEngine.Core.Stats
{
    public class FloatTypedStat<T> : BaseTypedStat<float, T> where T : Enum
    {
        protected FloatTypedStat(string name, float value, T type) : base(name, value, type)
        {
            AddValues = (val, mod) => val + mod;
        }
    }
}