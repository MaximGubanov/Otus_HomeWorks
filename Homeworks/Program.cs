using System.Diagnostics;
using Homeworks._4_Reflection;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

var f = new F().Get();
var csv = String.Empty;
var json = String.Empty;
object obj;
var limit = 1000000;

var timer1 = new Stopwatch();
timer1.Start();
for (var i = 0; i < limit; i++)
{
    csv = SerializerCsv.SerializeToCsvString(f);
}
timer1.Stop();
Console.WriteLine($"Время сериализации моего метода: {timer1.Elapsed}");

var timer2 = new Stopwatch();
timer2.Start();
for (var i = 0; i < limit; i++)
{
    obj = SerializerCsv.DeserializeToObject<F>(csv);
}
timer2.Stop();
Console.WriteLine($"Время десериализации моего метода: {timer2.Elapsed}");

var timer3 = new Stopwatch();
timer3.Start();
json = JsonSerializer.Serialize(f); 
timer3.Stop();
Console.WriteLine($"{timer3.Elapsed}");

var timer4 = new Stopwatch();
timer4.Start();
var o = JsonConvert.DeserializeObject<F>(json);
timer4.Stop();
Console.WriteLine($"{timer4.Elapsed}");