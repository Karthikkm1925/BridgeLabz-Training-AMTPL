using System;
using System.Collections.Generic;

namespace BridgeLabzConsoleApp.collections
{
    public class QueueDemo
    {
        public static void Main()
        {
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("A");
            queue.Enqueue("B");
            queue.Enqueue("C");
            queue.Enqueue("D");
            queue.Enqueue("E");

            Console.WriteLine("Initial Queue Values");
            foreach (string item in queue)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nFront element using Peek: " + queue.Peek());

            string removedItem = queue.Dequeue();
            Console.WriteLine("Removed element using Dequeue: " + removedItem);

            Console.WriteLine("Queue after Dequeue");
            foreach (string item in queue)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nQueue Contains B: " + queue.Contains("B"));
            Console.WriteLine("Queue Count: " + queue.Count);

            string[] arr = queue.ToArray();
            Console.WriteLine("Queue converted to Array");
            foreach (string item in arr)
            {
                Console.Write(item + " ");
            }

            queue.TrimExcess();
            Console.WriteLine("\nTrimmed Excess Capacity");

            queue.Clear();
            Console.WriteLine("Queue Cleared");
            Console.WriteLine("Count after Clear: " + queue.Count);
        }
    }
}
