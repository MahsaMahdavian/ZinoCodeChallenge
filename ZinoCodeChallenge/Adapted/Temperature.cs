using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZinoCodeChallenge
{
    public class Temperature
    {

        /// <summary>
        /// واحد پایه سلسیوس
        /// </summary>
        public class c : IUnit
        {
            public double toBase => 1;
        }
        /// <summary>
        /// کلوین
        /// </summary>
        public class K : IUnit
        {
            public double toBase => 273.15;
        }

        /// <summary>
        /// فارنهایت
        /// </summary>
        public class F : IUnit
        {
            public double toBase => 0.001;
        }


    }
}
