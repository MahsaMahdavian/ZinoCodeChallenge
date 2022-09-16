using ZinoCodeChallenge.Adapter;

namespace ZinoCodeChallenge
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
                var a = Convert.ToDecimal(_value);
                return a.ToString();
          
        }
      

    }

}