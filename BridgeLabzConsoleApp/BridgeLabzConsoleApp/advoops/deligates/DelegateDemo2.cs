using System;
 
namespace BridgeLabzConsoleApp.advoops.deligates
{
    public delegate string GreetingDelegate(string str);
    public class DelegateDemo2
    {
        public static void Main()
        {
            Console.WriteLine("Ananymous Delegates ");
            GreetingDelegate obj;
            obj = delegate(string str)
            {
                return str;
            };
            string str = obj("Hello This is Delegate Here....");
            Console.WriteLine(str);
        }
    }
}
