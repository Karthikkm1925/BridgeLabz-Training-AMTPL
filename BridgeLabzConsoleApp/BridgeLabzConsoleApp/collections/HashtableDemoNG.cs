using System;
using System.Collections;

namespace BridgeLabzConsoleApp.collections
{
    public class HashtableDemoNG
    {
        public static void Main()
        {
            Hashtable ht = new Hashtable();

            ht.Add(1, "one");
            ht.Add(2, "two");
            ht.Add(3, "three");
            ht.Add(4, "four");

            Console.WriteLine("\nInitial Hashtable");
            foreach (DictionaryEntry entry in ht)
            {
                Console.Write(entry.Key + ":" + entry.Value + "  ");
            }

            ht[5] = "five";
            Console.WriteLine("\nAfter adding key 5 using indexer");
            foreach (DictionaryEntry entry in ht)
            {
                Console.Write(entry.Key + ":" + entry.Value + "  ");
            }

            Console.WriteLine("\nContains key 3: " + ht.ContainsKey(3));
            Console.WriteLine("Contains value 'two': " + ht.ContainsValue("two"));

            ht.Remove(2);
            Console.WriteLine("\nAfter removing key 2");
            foreach (DictionaryEntry entry in ht)
            {
                Console.Write(entry.Key + ":" + entry.Value + "  ");
            }

            Console.WriteLine("\nTotal Count: " + ht.Count);

            Console.WriteLine("\nAll Keys");
            foreach (var key in ht.Keys)
            {
                Console.Write(key + " ");
            }

            Console.WriteLine("\nAll Values");
            foreach (var val in ht.Values)
            {
                Console.Write(val + " ");
            }

            Hashtable copy = (Hashtable)ht.Clone();
            Console.WriteLine("\nCloned Hashtable");
            foreach (DictionaryEntry entry in copy)
            {
                Console.Write(entry.Key + ":" + entry.Value + "  ");
            }

            DictionaryEntry[] arr = new DictionaryEntry[ht.Count];
            ht.CopyTo(arr, 0);
            Console.WriteLine("\nCopied to array");
            foreach (var item in arr)
            {
                Console.Write(item.Key + ":" + item.Value + "  ");
            }

            ht.Clear();
            Console.WriteLine("\nHashtable cleared");
            Console.WriteLine("Count after clear: " + ht.Count);
        }
    }
}
