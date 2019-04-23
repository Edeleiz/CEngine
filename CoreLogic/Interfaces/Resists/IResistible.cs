using System;
using System.Collections.Generic;

namespace CEngine.Interfaces.Resists
{
    public interface IResistible
    {
        List<IResist> GetResists(object type);
        void AddResist(IResist resist);
    }

    public interface IResistible<T> : IResistible where T : Enum
    {
        List<IResist<T>> GetResists(T type);
        void AddResist(IResist<T> resist);
    }
}