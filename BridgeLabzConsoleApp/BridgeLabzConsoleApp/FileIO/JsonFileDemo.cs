
using System.Text.Json;

namespace BridgeLabzConsoleApp.FileIO
{
    public class JsonFileDemo
    {

        public static void Main()
        {
            Employee e = new Employee
            {
                Id = 1,
                Role = "Developer",
                sal = 6000000
            };

            string jsonFile = JsonSerializer.Serialize(e);

            File.WriteAllText("EmployeData.json",jsonFile);

            string Data = File.ReadAllText("EmployeData.json");

            Employee res = JsonSerializer.Deserialize<Employee>(Data);
            
            Console.WriteLine($"{res.Id} {res.Role} {res.sal}");
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Role { get; set; }
        public decimal sal { get; set; }
    }
}
