using ZinoCodeChallenge.Adapted;
using ZinoCodeChallenge.Adapter;

namespace ZinoCodeChallenge.Adapter
{
    public class Adapter<T> where T : IUnit
    {
        public readonly double _value;
        public Adapter(double value)
        {
            _value = value;
        }

        public string CalculateUnit()
        {           
                decimal toDecimal = Convert.ToDecimal(_value);
                return toDecimal.ToString();
          
        }
      

    }

}