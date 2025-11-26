using System;
using System.Collections.Concurrent;

namespace BridgeLabzConsoleApp.collections
{
    public class ConcurrentStackDemo
    {
        public static void Main()
        {
            ConcurrentStack<int> stack = new ConcurrentStack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            Console.WriteLine("Initial Stack:");
            foreach (int i in stack)
            {
                Console.Write(i + " ");
            }

            stack.TryPop(out int poppedValue);
            Console.WriteLine("\nAfter TryPop, removed: " + poppedValue);
            Console.WriteLine("Stack now:");
            foreach (int i in stack)
            {
                Console.Write(i + " ");
            }

            stack.TryPeek(out int peekedValue);
            Console.WriteLine("\nPeeked value (top of stack): " + peekedValue);

            int[] array = stack.ToArray();
            Console.WriteLine("Stack converted to array:");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }

            stack.Clear();
            Console.WriteLine("\nStack cleared, count: " + stack.Count);
        }
    }
}
