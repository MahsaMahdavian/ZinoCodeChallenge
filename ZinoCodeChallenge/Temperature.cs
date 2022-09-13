using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZinoCodeChallenge
{
    public class Temperature
    {
        public interface ITemperature : IUnit
        {
        }
        /// <summary>
        /// واحد پایه سلسیوس
        /// </summary>
        public class c : ITemperature
        {
            public double toBase =>1; 
        }
        /// <summary>
        /// کلوین
        /// </summary>
        public class K : ITemperature
        {
            public double toBase => 273.15;
        }

        /// <summary>
        /// فارنهایت
        /// </summary>
        public class F : ITemperature
        {
            public double toBase => 0.001;
        }

        public static Adapter<R> ConvertUnit<T, R>(Adapter<T> adaptee) where T : ITemperature, new() where R : ITemperature, new()
        {
            double mabda = (new T() as IUnit).toBase;
            //double _base = (new R() as IUnit).toBase;
            //var result = -new Adapter<R>(mabda);
            var result = new Adapter<R>(adaptee._value - mabda);
            return result;
        }
    }
}
