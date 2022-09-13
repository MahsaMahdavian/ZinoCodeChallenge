namespace ZinoCodeChallenge
{
    public class Adapter<T> where T : IUnit
    {
        public readonly double _value;
        public Adapter(double value)
        {
            _value = value;
        }

        public string GetSpecificRequest()
        {
            var a= Convert.ToDecimal(_value);
            return a.ToString();
        }
        public static Adapter<T> operator *(Adapter<T> first, Adapter<T> second)
        {
            return new Adapter<T>(first._value * second._value);
        }
        public static Adapter<T> operator +(Adapter<T> first)
        {
            return new Adapter<T>(+first._value);
        }
        public static Adapter<T> operator -(Adapter<T> first)
        {
            return new Adapter<T>(- first._value);
        }
        public static Adapter<T> operator /(Adapter<T> first, Adapter<T> second)
        {
            return new Adapter<T>(first._value / second._value);
        }

    }

}