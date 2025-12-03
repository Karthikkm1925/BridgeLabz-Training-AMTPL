using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzConsoleApp.advoops.deligates
{

    public delegate string GreetPerson(string name);
    public class LambdaDemo
    {
        public static void Main()
        {
            Console.WriteLine("Lambda Expression");
            GreetPerson obj;
            obj = (name) =>
            {
                return "Hi : "+name;
            };
            Console.WriteLine("Enetr the Name of Person");
            string str = obj(Console.ReadLine());
            Console.WriteLine(str);
        }
    }
}
