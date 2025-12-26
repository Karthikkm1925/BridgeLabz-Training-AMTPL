using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BridgeLabzConsoleApp.FileIO
{
    public class JsonFileTask
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(1, "Naman", "FullStack Java", 200000));
            students.Add(new Student(2, "Aman", "FullStack Python", 200000));
            students.Add(new Student(3, "Suman", "FullStack C++", 200000));
            students.Add(new Student(4, "Gamyam", "FullStack .NET", 200000));


            string path = "student.json";

            File.WriteAllText(path,"[\n");
            for (int i = 0; i < students.Count; i++)
            {
                string studentdata = JsonSerializer.Serialize(students[i]);

                if (i < students.Count - 1)
                {
                    studentdata += ",";
                }

                File.AppendAllText(path, studentdata+"\n");
            }

            File.AppendAllText(path, "]");
                
            string json = File.ReadAllText(path);
 
            students = JsonSerializer.Deserialize<List<Student>>(json);

            foreach (var item in students) { 
                
                Console.WriteLine(item);
            }

        }
    }

    public class Student
    {
        int Id;
        string Name;
        string Course;
        double Fees;

        public Student() { }
        public Student(int Id, string Name, string Course, double Fees)
        {
            this.Id = Id;
            this.Name = Name;
            this.Course = Course;
            this.Fees = Fees;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Course: {Course}, Fees: {Fees}";
        }
    }
}
