using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZinoCodeChallenge
{
    public class Mass
    {

        /// <summary>
        /// واحد پایه گرم
        /// </summary>
        public class g : IUnit
        {
            public double toBase => 1; 
        }
        public class kg : IUnit
        {
            public double toBase => 1000;
        }
        public class ton : IUnit
        {
            public double toBase=> 1000000;
        }
        public class mg : IUnit
        {
            public double toBase=> 0.001;
        }

    }
}
