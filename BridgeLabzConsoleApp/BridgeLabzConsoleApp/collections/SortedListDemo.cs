using System;
using System.Collections.Generic;

namespace BridgeLabzConsoleApp.collections
{
    public class SortedListDemo
    {
        public static void Main()
        {
            SortedList<int, string> sl = new SortedList<int, string>();

            sl.Add(3, "three");
            sl.Add(1, "one");
            sl.Add(4, "four");
            sl.Add(2, "two");

            Console.WriteLine("\nInitial SortedList");
            foreach (KeyValuePair<int, string> kvp in sl)
            {
                Console.WriteLine(kvp.Key + ":" + kvp.Value);
            }

            sl[2] = "two updated";

            Console.WriteLine("\nAfter updating key 2");
            foreach (KeyValuePair<int, string> kvp in sl)
            {
                Console.WriteLine(kvp.Key + ":" + kvp.Value);
            }

            Console.WriteLine("\nKeys in SortedList");
            foreach (int key in sl.Keys)
            {
                Console.Write(key + " ");
            }

            Console.WriteLine("\nValues in SortedList");
            foreach (string val in sl.Values)
            {
                Console.Write(val + " ");
            }

            Console.WriteLine("\nContains key 3: " + sl.ContainsKey(3));
            Console.WriteLine("Contains value 'four': " + sl.ContainsValue("four"));

            Console.WriteLine("\nIndex of key 4: " + sl.IndexOfKey(4));
            Console.WriteLine("Index of value 'one': " + sl.IndexOfValue("one"));

            sl.Remove(1);
            Console.WriteLine("\nAfter removing key 1");
            foreach (KeyValuePair<int, string> kvp in sl)
            {
                Console.WriteLine(kvp.Key + ":" + kvp.Value);
            }

            sl.Clear();
            Console.WriteLine("\nSortedList cleared, Count: " + sl.Count);
        }
    }
}
