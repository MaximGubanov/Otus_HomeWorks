using System.Dynamic;

namespace Homeworks._4_Reflection;

public class F
{
    public int I1 { get; set; }
    public int I2 { get; set; }
    public int I3 { get; set; }
    public int I4 { get; set; }
    public int I5 { get; set; }

    public F Get() => new F { I1 = 1, I2 = 2, I3 = 3, I4 = 4, I5 = 5 };
}