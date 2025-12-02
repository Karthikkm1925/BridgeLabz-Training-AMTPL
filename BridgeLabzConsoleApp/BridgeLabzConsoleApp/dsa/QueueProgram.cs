using System;

namespace BridgeLabzConsoleApp.dsa
{
    public class QueueProgram
    {
        private int[] queue;
        private int toq;   
        private int boq;   

        public QueueProgram(int size)
        {
            queue = new int[size];
            toq = -1;
            boq = queue.Length;   
        }

        public bool IsFull()
        {
            return toq == queue.Length - 1;
        }

        public bool IsEmpty()
        {
            return toq == -1 || boq == queue.Length;
        }

        public void EnQueue(int value)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is Full");
            }
            else if (boq == -1)
            {
                boq = 0;   
                queue[++toq] = value;
            }
            else
            {
                queue[++toq] = value;
                Console.WriteLine($"{value} is Inserted");
            }
        }

        public void DeQueue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                int value = queue[++boq];

                if (boq > toq)
                {
                    boq = -1;
                    toq = -1;
                }

                Console.WriteLine($"{value} is Fetched");
            }
        }

        public void Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Console.WriteLine(queue[boq]);
            }
        }

        public void Delete()
        {
            queue = null;
            Console.WriteLine("Queue is Deleted");
        }
    }
}
