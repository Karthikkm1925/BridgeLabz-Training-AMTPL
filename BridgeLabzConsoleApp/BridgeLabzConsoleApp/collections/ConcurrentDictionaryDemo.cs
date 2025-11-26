using System;
using System.Collections.Concurrent;

namespace BridgeLabzConsoleApp.collections
{
    public class ConcurrentDictionaryDemo
    {
        public static void Main()
        {
            ConcurrentDictionary<int, string> dict = new ConcurrentDictionary<int, string>();

            dict.TryAdd(1, "one");
            dict.TryAdd(2, "two");
            dict.TryAdd(3, "three");
            dict.TryAdd(4, "four");

            Console.WriteLine("Initial Dictionary:");
            foreach (KeyValuePair<int, string> kv in dict)
            {
                Console.WriteLine(kv.Key + ":" + kv.Value);
            }

            dict[2] = "two updated";
            Console.WriteLine("\nUpdated value of key 2:");
            foreach (KeyValuePair<int, string> kv in dict)
            {
                Console.WriteLine(kv.Key + ":" + kv.Value);
            }

            string value;
            dict.TryRemove(3, out value);
            Console.WriteLine("\nAfter removing key 3:");
            foreach (KeyValuePair<int, string> kv in dict)
            {
                Console.WriteLine(kv.Key + ":" + kv.Value);
            }

            string result = dict.GetOrAdd(5, "five");
            Console.WriteLine("\nAfter GetOrAdd key 5:");
            foreach (KeyValuePair<int, string> kv in dict)
            {
                Console.WriteLine(kv.Key + ":" + kv.Value);
            }

            dict.AddOrUpdate(1, "one new", (key, oldValue) => oldValue + " updated");
            Console.WriteLine("\nAfter AddOrUpdate key 1:");
            foreach (KeyValuePair<int, string> kv in dict)
            {
                Console.WriteLine(kv.Key + ":" + kv.Value);
            }

            Console.WriteLine("\nContains key 2: " + dict.ContainsKey(2));
            Console.WriteLine("Count: " + dict.Count);

            dict.Clear();
            Console.WriteLine("Count after clear: " + dict.Count);
        }
    }
}
