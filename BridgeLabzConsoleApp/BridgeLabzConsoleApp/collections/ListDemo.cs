using System;
using System.Collections.Generic;

namespace BridgeLabzConsoleApp.collections
{
    public class ListDemo
    {
        public static void Main()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);

            Console.WriteLine("\nInitial List Values");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }

            List<int> list2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("\nThis is List 2");
            foreach (int i in list2)
            {
                Console.Write(i + " ");
            }

            list.AddRange(list2);

            Console.WriteLine("\nAfter merging list 2 with list 1");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }

            list.Insert(5, 8888);
            Console.WriteLine("\nInserted 8888 at index 5");

            List<int> list3 = new List<int> { 11, 22, 33, 44, 55 };

            Console.WriteLine("\nThis is List 3");
            foreach (int i in list3)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\nAfter adding list 3 to list 1 at index 5");
            list.InsertRange(5, list3);
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }

            list.Remove(33);
            Console.WriteLine("\nRemoved 33 from List");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }

            list.RemoveAt(0);
            Console.WriteLine("\nRemoved index 0");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }

            list.RemoveRange(5, 2);
            Console.WriteLine("\nAfter removing 2 elements from index 5");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\nList Contains 22: " + list.Contains(22));
            Console.WriteLine("Index of 44: " + list.IndexOf(44));
            Console.WriteLine("Count: " + list.Count);
            Console.WriteLine("Capacity: " + list.Capacity);

            int found = list.Find(x => x > 100);
            Console.WriteLine("First number > 100: " + found);

            List<int> allFound = list.FindAll(x => x % 2 == 0);
            Console.WriteLine("Even numbers:");
            foreach (int i in allFound)
            {
                Console.Write(i + " ");
            }

            list.Sort();
            Console.WriteLine("\nSorted List");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }

            list.Reverse();
            Console.WriteLine("\nReversed List");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }

            int[] arrayValues = list.ToArray();
            Console.WriteLine("\nConverted to Array");
            foreach (int i in arrayValues)
            {
                Console.Write(i + " ");
            }

            list.Clear();
            Console.WriteLine("\nList cleared");
            Console.WriteLine("Count after clear: " + list.Count);
        }
    }
}
