using System;

namespace BridgeLabzConsoleApp.advoops.deligates
{
    public delegate void SayDeligate();
    public class DeligateDemo1
    {
        static void SayHello()
        {
            Console.WriteLine("Hey there...!");
        }

        static void MethodOne()
        {
            Console.WriteLine("I am Method one");
        }

        static void MethodTwo()
        {
            Console.WriteLine("I am Method two");
        }

        public static void Main()
        {

            //SayDeligate sd = new SayDeligate(DeligateDemo1.SayHello);
            //sd();

            //SayDeligate sd = SayHello;
            //sd();

            SayDeligate sd;
            sd = SayHello;
            sd += MethodOne;
            sd += MethodTwo;
           // sd();
           sd.Invoke();
        }
        
    }
}
