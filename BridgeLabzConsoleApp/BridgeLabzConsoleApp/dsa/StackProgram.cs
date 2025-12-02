using System;

namespace BridgeLabzConsoleApp.dsa
{
    public class StackProgram
    {

        private int[] stack;
        private int topOfStack;
        public StackProgram(int size) 
        { 
            stack = new int[size];
            topOfStack = -1;
        }

        public bool IsEmpty()
        {
            if (topOfStack == -1)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Console.WriteLine("Stack has some elements");
            }
            return topOfStack == -1;
        }
        public bool IsFull()
        {
            if (topOfStack == stack.Length - 1)
            {
                Console.WriteLine("Stack is already full");
            }
            else
            {
                Console.WriteLine("Stack have some space yet");
            }
            return topOfStack == stack.Length-1;
        }

        public void push(int value)
        {
            if(IsFull()) 
            {
                return;
            }else
            {
                stack[++topOfStack] = value;
                Console.WriteLine($"The Element {value} is added at {topOfStack}");
            }   
        }

        public void pop()
        {
            if (IsEmpty())
            {
                return;
            }
            else
            {
                int value = stack[topOfStack];
                topOfStack--;
                Console.WriteLine($"The element {value} is removed from stack");
            }
        }

        public void peek()
        {
            if (IsEmpty())
            {
                return;
            }
            Console.WriteLine($"The top element is {stack[topOfStack]}");
        }

        public void count()
        {
            if (IsEmpty())
            {
                return;
            }
            Console.WriteLine($"There are {topOfStack+1} elements in stack");
        }

        public void clear()
        {
            topOfStack = -1;
        }
    }
}
