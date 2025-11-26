using System;
using System.Collections.Generic;

namespace BridgeLabzConsoleApp.collections
{
    public class LinkedListDemo
    {
        public static void Main()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);

            Console.WriteLine("\nInitial LinkedList values");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }

            list.AddFirst(0);
            Console.WriteLine("\nAfter adding 0 at first");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }

            list.AddLast(6);
            Console.WriteLine("\nAfter adding 6 at last");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }

            LinkedListNode<int> node = list.Find(3);
            if (node != null)
            {
                list.AddAfter(node, 33);
                list.AddBefore(node, 22);
            }

            Console.WriteLine("\nAfter adding 22 before 3 and 33 after 3");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }

            list.Remove(0);
            list.Remove(6);
            Console.WriteLine("\nAfter removing 0 and 6");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }

            list.RemoveFirst();
            list.RemoveLast();
            Console.WriteLine("\nAfter RemoveFirst and RemoveLast");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\nCount: " + list.Count);
            list.Clear();
            Console.WriteLine("After Clear, Count: " + list.Count);
        }
    }
}
