using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZinoCodeChallenge.Adapted
{
    public class m : IUnit
    {
        public double toBase => 1;
    }
    public class mm : IUnit
    {
        public double toBase => 0.001;
    }
    public class cm : IUnit
    {
        public double toBase => 0.01;
    }
    public class km : IUnit
    {
        public double toBase => 1000;
    }

}
