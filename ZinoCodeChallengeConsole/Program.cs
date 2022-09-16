using ZinoCodeChallenge.Adapter;
using static ZinoCodeChallenge.Adapted.Length;
using static ZinoCodeChallenge.Adapted.Mass;

Console.WriteLine("Hello, World!");

var adapter = new Adapter<mm>(5);
var adaptermass = new Adapter<ton>(8);
Convertor convertorLength = new LengthConvertor();
Convertor convertorMass = new MassConvertor();
var aim = convertorLength.ConvertUnit<mm, km>(adapter);
var aimMass = convertorMass.ConvertUnit<ton, mg>(adaptermass);
Console.WriteLine(aimMass.CalculateUnit());
Console.WriteLine(aim.CalculateUnit());
Console.ReadLine();