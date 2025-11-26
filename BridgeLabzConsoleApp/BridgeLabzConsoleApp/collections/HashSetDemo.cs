using System;
using System.Collections.Generic;

namespace BridgeLabzConsoleApp.collections
{
    public class HashSetDemo
    {
        public static void Main()
        {
            HashSet<int> set = new HashSet<int>();

            set.Add(10);
            set.Add(20);
            set.Add(30);
            set.Add(40);
            set.Add(50);

            Console.WriteLine("Initial HashSet Values");
            foreach (int i in set)
            {
                Console.Write(i + " ");
            }

            bool added = set.Add(30);
            Console.WriteLine("\nTrying to add 30 again, Added: " + added);

            Console.WriteLine("HashSet Contains 40: " + set.Contains(40));

            set.Remove(20);
            Console.WriteLine("Removed 20");

            Console.WriteLine("HashSet After Remove");
            foreach (int i in set)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\nHashSet Count: " + set.Count);

            int[] arr = new int[set.Count];
            set.CopyTo(arr);
            Console.WriteLine("Copied to Array");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            HashSet<int> set2 = new HashSet<int>() { 30, 60, 70 };

            set.UnionWith(set2);
            Console.WriteLine("\nAfter UnionWith");
            foreach (int i in set)
            {
                Console.Write(i + " ");
            }

            set.IntersectWith(set2);
            Console.WriteLine("\nAfter IntersectWith");
            foreach (int i in set)
            {
                Console.Write(i + " ");
            }

            set.ExceptWith(set2);
            Console.WriteLine("\nAfter ExceptWith");
            foreach (int i in set)
            {
                Console.Write(i + " ");
            }

            set.Clear();
            Console.WriteLine("\nHashSet Cleared");
            Console.WriteLine("Count after Clear: " + set.Count);
        }
    }
}
