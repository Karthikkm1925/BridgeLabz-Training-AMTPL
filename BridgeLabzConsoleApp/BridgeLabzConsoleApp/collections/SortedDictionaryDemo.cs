using System;
using System.Collections.Generic;

namespace BridgeLabzConsoleApp.collections
{
    public class SortedDictionaryDemo
    {
        public static void Main()
        {
            SortedDictionary<int, string> sd = new SortedDictionary<int, string>();
            sd.Add(3, "Three");
            sd.Add(1, "One");
            sd.Add(5, "Five");
            sd.Add(2, "Two");

            Console.WriteLine("\nInitial SortedDictionary");
            foreach (KeyValuePair<int, string> item in sd)
            {
                Console.Write(item.Key + ":" + item.Value + "  ");
            }

            Console.WriteLine("\nAccessing value at key 1");
            Console.WriteLine(sd[1]);

            sd[2] = "TwoUpdated";
            Console.WriteLine("\nUpdated key 2");
            foreach (KeyValuePair<int, string> item in sd)
            {
                Console.Write(item.Key + ":" + item.Value + "  ");
            }

            Console.WriteLine("\nContains key 3: " + sd.ContainsKey(3));
            Console.WriteLine("Contains value \"Five\": " + sd.ContainsValue("Five"));

            Console.WriteLine("\nAll Keys");
            foreach (int key in sd.Keys)
            {
                Console.Write(key + " ");
            }

            Console.WriteLine("\nAll Values");
            foreach (string v in sd.Values)
            {
                Console.Write(v + " ");
            }

            sd.Remove(5);
            Console.WriteLine("\nAfter removing key 5");
            foreach (KeyValuePair<int, string> item in sd)
            {
                Console.Write(item.Key + ":" + item.Value + "  ");
            }

            Console.WriteLine("\nCount: " + sd.Count);

            SortedDictionary<int, string> sd2 = new SortedDictionary<int, string>();
            sd2.Add(7, "Seven");
            sd2.Add(6, "Six");

            Console.WriteLine("\nThis is sd2");
            foreach (KeyValuePair<int, string> item in sd2)
            {
                Console.Write(item.Key + ":" + item.Value + "  ");
            }

            foreach (KeyValuePair<int, string> item in sd2)
            {
                sd[item.Key] = item.Value;
            }

            Console.WriteLine("\nAfter adding sd2 to sd");
            foreach (KeyValuePair<int, string> item in sd)
            {
                Console.Write(item.Key + ":" + item.Value + "  ");
            }

            Console.WriteLine("\nTryAdd operations");
            bool a = sd.TryAdd(8, "Eight");
            Console.WriteLine(a);
            bool b = sd.TryAdd(1, "OneAgain");
            Console.WriteLine(b);

            Console.WriteLine("\nAfter TryAdd calls");
            foreach (KeyValuePair<int, string> item in sd)
            {
                Console.Write(item.Key + ":" + item.Value + "  ");
            }

            string found;
            sd.TryGetValue(7, out found);
            Console.WriteLine("\nValue from TryGetValue key 7: " + found);

            Console.WriteLine("\nConverted to array");
            KeyValuePair<int, string>[] arr = new KeyValuePair<int, string>[sd.Count];
            sd.CopyTo(arr, 0);
            foreach (KeyValuePair<int, string> i in arr)
            {
                Console.Write(i.Key + ":" + i.Value + "  ");
            }

            sd.Clear();
            Console.WriteLine("\nCleared sd");
            Console.WriteLine("Count after clear: " + sd.Count);
        }
    }
}
