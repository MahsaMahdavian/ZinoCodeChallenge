using ZinoCodeChallenge;


//var a = new Adapter<Length.mm>(5);
var ConvertKevinToBase = new Adapter<Temperature.K>(1);
var Celcious= Temperature.ConvertUnit<Temperature.K, Temperature.c>(ConvertKevinToBase);
//var e = Length.ConvertUnit<Length.mm, Length.km>(a);
//Console.WriteLine(e.GetSpecificRequest());

Console.WriteLine(Celcious.GetSpecificRequest());
Console.ReadLine();