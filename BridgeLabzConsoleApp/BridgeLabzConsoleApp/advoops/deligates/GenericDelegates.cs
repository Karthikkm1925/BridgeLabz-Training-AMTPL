using System;
 
namespace BridgeLabzConsoleApp.advoops.deligates
{

    public delegate double Addition(int a, int b);
    public delegate void StringConcat(string a, string b);
    public delegate bool TrueOrFalse(string name);
    public class GenericDelegates
    {
        public static double AddMethod(int a, int b)
        {
            return a + b;
        }

        public static void StringJoin(string str1, string str2)
        {
            Console.WriteLine(str1 + str2);
        }

        public static bool CheckLength(string str)
        {
            return str.Length >=3;
        }
        public static void Main()
        {
            Console.WriteLine("Generic Delegates Demo");

            Console.WriteLine("Function Delegate");
            Func<int, int, double> obj1;
                obj1 = AddMethod;
            double sum = obj1(1,2);
            Console.WriteLine(sum);

            Console.WriteLine("Action Delegate");
            Action<string,string> obj2;
            obj2 = StringJoin;
            obj2("First "," Second");

            Console.WriteLine("Predicate Delegate");
            Predicate<string> obj3;
            obj3 = CheckLength;
            bool got = obj3("abc");
            Console.WriteLine(got);

            Console.WriteLine("Prdicate using Func is possible to fullfill usecase");
            Func<string,bool> obj4;
            obj4 = CheckLength;
            bool gotit = obj4("abc");
            Console.WriteLine(gotit);
        }
    }
}
