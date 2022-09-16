using ZinoCodeChallenge;
using ZinoCodeChallenge.Adapted;
using ZinoCodeChallenge.Adapter;
using static ZinoCodeChallenge.Mass;

//var ConvertKevinToBase = new Adapter<Temperature.K>(1);
//var Celcious= Temperature.ConvertUnit<Temperature.K, Temperature.c>(ConvertKevinToBase);
//Console.WriteLine(Celcious.GetSpecificRequest());

var adapter = new Adapter<mm>(5);
var adaptermass = new Adapter<ton>(8);
Convertor convertorLength = new LengthConvertor();
Convertor convertorMass = new MassConvertor();
 var aim=convertorLength.ConvertUnit<mm,km>(adapter);
 var aimMass= convertorMass.ConvertUnit<ton,mg>(adaptermass);
Console.WriteLine(aimMass.CalculateUnit());
Console.WriteLine(aim.CalculateUnit());
Console.ReadLine();