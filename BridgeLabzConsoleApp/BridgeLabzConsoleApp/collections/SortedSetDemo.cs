using System;
using System.Collections.Generic;

namespace BridgeLabzConsoleApp.collections
{
    public class SortedSetDemo
    {
        public static void Main()
        {
            SortedSet<int> set = new SortedSet<int>();
            set.Add(5);
            set.Add(3);
            set.Add(8);
            set.Add(1);
            set.Add(7);

            Console.WriteLine("\nInitial SortedSet Values");
            foreach (int i in set)
            {
                Console.Write(i + " ");
            }

            set.Remove(3);
            Console.WriteLine("\nAfter removing 3");
            foreach (int i in set)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\nContains 5: " + set.Contains(5));
            Console.WriteLine("Contains 3: " + set.Contains(3));

            Console.WriteLine("Count: " + set.Count);
            Console.WriteLine("Min: " + set.Min);
            Console.WriteLine("Max: " + set.Max);

            SortedSet<int> set2 = new SortedSet<int> { 2, 5, 7, 9 };

            set.UnionWith(set2);
            Console.WriteLine("\nAfter UnionWith set2");
            foreach (int i in set)
            {
                Console.Write(i + " ");
            }

            set.IntersectWith(set2);
            Console.WriteLine("\nAfter IntersectWith set2");
            foreach (int i in set)
            {
                Console.Write(i + " ");
            }

            set.ExceptWith(new int[] { 5 });
            Console.WriteLine("\nAfter ExceptWith 5");
            foreach (int i in set)
            {
                Console.Write(i + " ");
            }

            set.Clear();
            Console.WriteLine("\nSortedSet cleared");
            Console.WriteLine("Count after clear: " + set.Count);
        }
    }
}
