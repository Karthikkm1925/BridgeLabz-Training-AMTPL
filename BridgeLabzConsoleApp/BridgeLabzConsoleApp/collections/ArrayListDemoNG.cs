using System;
using System.Collections;

namespace BridgeLabzConsoleApp.collections
{
    public class ArrayListDemoNG
    {
        public static void Main()
        {
            ArrayList arr = new ArrayList();

            arr.Add(1);
            arr.Add(2);
            arr.Add(3);
            arr.Add(4);
            arr.Add(5);

            Console.WriteLine("\nInitial Values");
            foreach (var i in arr) Console.Write(i + " ");

            ArrayList arr2 = new ArrayList() { 6, 7, 8, 9 };
            Console.WriteLine("\nArrayList 2 Values");
            foreach (var i in arr2) Console.Write(i + " ");

            arr.AddRange(arr2);
            Console.WriteLine("\nAfter AddRange(arr2)");
            foreach (var i in arr) Console.Write(i + " ");

            arr.Insert(3, 999);
            Console.WriteLine("\nInserted 999 at index 3");
            foreach (var i in arr) Console.Write(i + " ");

            ArrayList arr3 = new ArrayList() { 11, 22, 33 };
            Console.WriteLine("\nArrayList 3 Values");
            foreach (var i in arr3) Console.Write(i + " ");

            arr.InsertRange(2, arr3);
            Console.WriteLine("\nAfter InsertRange(arr3 at index 2)");
            foreach (var i in arr) Console.Write(i + " ");

            arr.Remove(33);
            Console.WriteLine("\nRemoved 33");
            foreach (var i in arr) Console.Write(i + " ");

            arr.RemoveAt(0);
            Console.WriteLine("\nRemoved index 0");
            foreach (var i in arr) Console.Write(i + " ");

            arr.RemoveRange(2, 2);
            Console.WriteLine("\nRemoved 2 elements from index 2");
            foreach (var i in arr) Console.Write(i + " ");

            Console.WriteLine("\nContains 22: " + arr.Contains(22));
            Console.WriteLine("Index of 999: " + arr.IndexOf(999));
            Console.WriteLine("Last index of 7: " + arr.LastIndexOf(7));

            Console.WriteLine("Count: " + arr.Count);
            Console.WriteLine("Capacity: " + arr.Capacity);

            arr.Sort();
            Console.WriteLine("\nSorted ArrayList");
            foreach (var i in arr) Console.Write(i + " ");

            arr.Reverse();
            Console.WriteLine("\nReversed ArrayList");
            foreach (var i in arr) Console.Write(i + " ");

            ArrayList subList = arr.GetRange(2, 3);
            Console.WriteLine("\nGetRange(2,3)");
            foreach (var i in subList) Console.Write(i + " ");

            object[] arrValues = arr.ToArray();
            Console.WriteLine("\nConverted to normal array");
            foreach (var i in arrValues) Console.Write(i + " ");

            arr.TrimToSize();
            Console.WriteLine("\nCapacity after TrimToSize: " + arr.Capacity);

            arr.Clear();
            Console.WriteLine("ArrayList cleared");
            Console.WriteLine("Count after clear: " + arr.Count);
        }
    }
}
