using System;
using System.Collections;

namespace BridgeLabzConsoleApp.collections
{
    public class StackDemoNG
    {
        public static void Main()
        {
            Stack stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            Console.WriteLine("\nInitial Stack Values");
            foreach (object i in stack)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\nPeek top element: " + stack.Peek());

            Console.WriteLine("Pop top element: " + stack.Pop());

            Console.WriteLine("\nStack after Pop");
            foreach (object i in stack)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\nStack contains 3: " + stack.Contains(3));
            Console.WriteLine("Stack count: " + stack.Count);

            stack.Clear();
            Console.WriteLine("\nStack cleared. Count now: " + stack.Count);
        }
    }
}
