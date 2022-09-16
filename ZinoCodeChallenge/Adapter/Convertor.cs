using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZinoCodeChallenge.Adapter
{
    public abstract class Convertor
    {

        public abstract Adapter<R> ConvertUnit<T, R>(Adapter<T> first) where T : IUnit ,new() where  R : IUnit, new();
}
}
