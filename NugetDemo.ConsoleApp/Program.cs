using NugetDemo.PackageDemo;
using System.Dynamic;

namespace NugetDemo.ConsoleApp;
internal class Program
{
    static void Main(string[] args)
    {
        dynamic person = new ExpandoObject();
        person.Name = "John Doe";
        person.Age = 30;
        person.Email = "john.doe@example.com";
        person.Address = new ExpandoObject();
        person.Address.Street = "123 Main St";
        person.Address.City = "Anytown";
        person.Address.ZipCode = "12345";


        Console.WriteLine((person as object).ToJson());
    }
}
