using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZinoCodeChallenge.Adapter
{
    public class TemperatureConvertor : Convertor
    {
        public override Adapter<R> ConvertUnit<T, R>(Adapter<T> first)
        {
            throw new NotImplementedException();
        }
    }
}
