using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZinoCodeChallenge
{
    public class Mass
    {
        public interface IMass : IUnit { }

        /// <summary>
        /// واحد پایه گرم
        /// </summary>
        public class g : IMass
        {
            public double toBase => 1; 
        }
        public class kg : IMass
        {
            public double toBase => 1000;
        }
        public class ton : IMass
        {
            public double toBase=> 1000000;
        }
        public class mg : IMass
        {
            public double toBase=> 0.001;
        }

    }
}
