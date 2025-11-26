using System;
using System.Collections.Concurrent;

namespace BridgeLabzConsoleApp.collections
{
    public class ConcurrentQueueDemo
    {
        public static void Main()
        {
            ConcurrentQueue<int> queue = new ConcurrentQueue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            Console.WriteLine("Initial Queue:");
            foreach (int i in queue)
            {
                Console.Write(i + " ");
            }

            queue.TryDequeue(out int dequeuedValue);
            Console.WriteLine("\nAfter TryDequeue, removed: " + dequeuedValue);
            Console.WriteLine("Queue now:");
            foreach (int i in queue)
            {
                Console.Write(i + " ");
            }

            queue.TryPeek(out int peekedValue);
            Console.WriteLine("\nPeeked value (front of queue): " + peekedValue);

            int[] array = queue.ToArray();
            Console.WriteLine("Queue converted to array:");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }

            queue.Clear();
            Console.WriteLine("\nQueue cleared, count: " + queue.Count);
        }
    }
}
