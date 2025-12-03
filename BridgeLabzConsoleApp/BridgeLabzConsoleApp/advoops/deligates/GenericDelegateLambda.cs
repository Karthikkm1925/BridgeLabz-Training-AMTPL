using System;

namespace BridgeLabzConsoleApp.advoops.deligates
{

    public delegate double AdditionDelegate(int a, int b);
    public delegate void StringConcatDelegate(string a, string b);
    public delegate bool TrueOrFalseDelegate(string name);

    public class GenericDelegateLambda
    {
        public static void Main()
        {
            Console.WriteLine("Generic Delegates Demo Using Lambda");

            Console.WriteLine("Function Delegate");
            Func<int, int, double> obj1;
            obj1 = (a, b) => a + b;
            double sum = obj1(1, 2);
            Console.WriteLine(sum);

            Console.WriteLine("Action Delegate");
            Action<string, string> obj2;
            obj2 = (str1, str2) => Console.WriteLine(str1 + str2);
            obj2("First ", " Second");

            Console.WriteLine("Predicate Delegate");
            Predicate<string> obj3;
            obj3 = str => str.Length >= 3;
            bool got = obj3("abc");
            Console.WriteLine(got);

            Console.WriteLine("Predicate using Func is possible to fulfill usecase");
            Func<string, bool> obj4;
            obj4 = str => str.Length >= 3;
            bool gotit = obj4("abc");
            Console.WriteLine(gotit);
        }
    }
}

