using System.Diagnostics;

namespace Homeworks._4_Reflection;

public static class PerformanceTest
{
    public static void Test(int limit)
    {
        var timer = new Stopwatch();
        
        timer.Start();
        
        for (var i = 0; i < limit; i++)
        {
            
        }
        
        timer.Stop();

        Console.WriteLine(timer.Elapsed);
    }

    public static void SerializeTest()
    {
        
    }
}