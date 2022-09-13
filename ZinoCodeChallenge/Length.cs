using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZinoCodeChallenge
{
    public static class Length
    {
        public interface ILength : IUnit { }
        public class m : ILength
        {
            public double toBase => 1;
        }
        public class mm : ILength
        {
            public double toBase => 0.001;
        }
        public class cm : ILength
        {
            public double toBase => 0.01;
        } 
        public class km : ILength
        {
            public double toBase => 1000;
        }

        public static Adapter<R> ConvertUnit<T, R>(Adapter<T> adaptee) where T : ILength, new() where R : ILength, new()
        {
            double mult = (new T() as IUnit).toBase;
            double div = (new R() as IUnit).toBase;
            var result = new Adapter<R>(adaptee._value * mult / div);
            return result;
        }
    }
}
