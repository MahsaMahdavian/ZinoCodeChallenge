using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZinoCodeChallenge.Adapter
{
    public class MassConvertor : Convertor
    {
        public override Adapter<R> ConvertUnit<T, R>(Adapter<T> first)
        {
            double mult = (new T() as IUnit).toBase;
            double div = (new R() as IUnit).toBase;
            var result = new Adapter<R>(first._value * mult / div);
            return result;
        }
    }
}
