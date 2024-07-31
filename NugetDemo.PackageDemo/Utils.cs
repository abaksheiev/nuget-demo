using System.Text.Json;

namespace NugetDemo.PackageDemo;

public static class Utils
{
    public static string ToJson(this object data) {
        return JsonSerializer.Serialize(data);
    }

    public static T From<T>(this string data)
    {
        return JsonSerializer.Deserialize<T>(data);
    }
}
