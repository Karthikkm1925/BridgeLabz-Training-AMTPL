using System;

namespace BridgeLabzConsoleApp.Basics.arrayproblems
{
    public class MoveZerosToEnd
    {
        public static void Main()
        {
            int[] numbers = { 1, 0, 2, 0, 4, 5, 0, 6 };

            Console.Write("Array after moving zeros to end: ");

            // First, print all non-zero numbers
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != 0)
                {
                    Console.Write(numbers[i] + " ");
                }
            }

            // Then, print all zeros
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 0)
                {
                    Console.Write("0 ");
                }
            }
        }
    }
}
