using System;
using System.Collections.Generic;

namespace BridgeLabzConsoleApp.Collections
{
    public class DictionaryDemo
    {
        public static void Main()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(1, "one");
            dict.Add(2, "two");
            dict.Add(3, "three");
            dict.Add(4, "four");
            dict.Add(5, "five");
            dict.Add(6, "six");
            dict.Add(7, "seven");

            dict[8] = "eight";
            dict.TryAdd(9, "nine");
            
            dict.TryGetValue(4, out string num);
            Console.WriteLine("Value of key 9: " + num);

            Console.WriteLine("Contains key 9: " + dict.ContainsKey(9));
            Console.WriteLine("Contains value 'nine': " + dict.ContainsValue("nine"));

            dict[6] = "six updated";
            Console.WriteLine("Updated key 6 value: " + dict[6]);

            Console.WriteLine("Keys:");
            foreach (int key in dict.Keys)
            {
                Console.Write(key + " ");
            }

            Console.WriteLine("\nValues:");
            foreach (string value in dict.Values)
            {
                Console.Write(value + " ");
            }

            Console.WriteLine("\nCount: " + dict.Count);

            dict.Remove(3);
            Console.WriteLine("Removed key 3");

            dict.Clear();
            Console.WriteLine("Dictionary cleared");
        }
    }
}
