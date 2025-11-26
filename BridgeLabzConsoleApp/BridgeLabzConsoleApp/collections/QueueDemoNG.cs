using System;
using System.Collections;

namespace BridgeLabzConsoleApp.collections
{
    public class QueueDemoNG
    {
        public static void Main()
        {
            Queue queue = new Queue();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);

            Console.WriteLine("\nInitial Queue");
            foreach (object item in queue)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nPeek front element: " + queue.Peek());

            object removed = queue.Dequeue();
            Console.WriteLine("Dequeued element: " + removed);

            Console.WriteLine("\nQueue after dequeue");
            foreach (object item in queue)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nQueue contains 30: " + queue.Contains(30));
            Console.WriteLine("Queue count: " + queue.Count);

            queue.Clear();
            Console.WriteLine("\nQueue cleared");
            Console.WriteLine("Count after clear: " + queue.Count);
        }
    }
}
