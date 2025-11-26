using System;
using System.Collections.Concurrent;

namespace BridgeLabzConsoleApp.collections
{
    public class ConcurrentBagDemo
    {
        public static void Main()
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();

            bag.Add(1);
            bag.Add(2);
            bag.Add(3);
            bag.Add(4);
            bag.Add(5);

            Console.WriteLine("Initial ConcurrentBag items:");
            foreach (int i in bag)
            {
                Console.Write(i + " ");
            }

            bag.TryPeek(out int peeked);
            Console.WriteLine("\nPeeked item: " + peeked);

            bag.TryTake(out int taken);
            Console.WriteLine("Taken item: " + taken);

            Console.WriteLine("Remaining items in bag:");
            foreach (int i in bag)
            {
                Console.Write(i + " ");
            }

            bag.Add(6);
            bag.Add(7);

            Console.WriteLine("\nAfter adding 6 and 7:");
            foreach (int i in bag)
            {
                Console.Write(i + " ");
            }

            int count = bag.Count;
            Console.WriteLine("\nCount of items in bag: " + count);

            bag.Clear();
            Console.WriteLine("After clearing, count: " + bag.Count);
        }
    }
}
