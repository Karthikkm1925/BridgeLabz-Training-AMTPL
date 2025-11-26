using System;
using System.Collections.Generic;

namespace BridgeLabzConsoleApp.collections
{
    public class StackDemo
    {
        public static void Main()
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            Console.WriteLine("Initial Stack Elements:");
            foreach (int i in stack)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\nPeek top element: " + stack.Peek());

            Console.WriteLine("Pop top element: " + stack.Pop());

            Console.WriteLine("Stack after Pop:");
            foreach (int i in stack)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\nContains 3: " + stack.Contains(3));
            Console.WriteLine("Stack count: " + stack.Count);

            stack.Clear();
            Console.WriteLine("Stack cleared, count: " + stack.Count);
        }
    }
}
