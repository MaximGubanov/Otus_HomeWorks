using System.Text;

namespace Homeworks._4_Reflection;

public static class SerializerCsv
{
    public static string SerializeToCsvString(object obj)
    {
        var headers = new List<string>();
        var values = new List<string>();
        var sb = new StringBuilder();
    
        var props = obj.GetType().GetProperties();
    
        foreach (var prop in props)
        {
            headers.Add(prop.Name);
            values.Add(prop.GetValue(obj).ToString());
        }
    
        var result = sb
            .Append(String.Join(";", headers))
            .Append(" ")
            .Append(String.Join(";", values))
            .ToString();

        return result;
    }

    public static T DeserializeToObject<T>(string str) where T : class
    {
        var splitString = str.Split(" ");
        var props = splitString[0].Split(";");
        var values = splitString[1].Split(";");
    
        var dict = new Dictionary<string, object>();
        for (int i = 0; i < props.Length; i++)
        {
            dict.Add(props[i], values[i]);
        }
    
        var instance = Activator.CreateInstance<T>();
    
        foreach (var d in dict)
        {
            var p = instance.GetType().GetProperty(d.Key);

            int number;
            bool success = int.TryParse((string?)d.Value, out number);
    
            if (success)
                p.SetValue(instance, number);
        }

        return instance;
    }
}