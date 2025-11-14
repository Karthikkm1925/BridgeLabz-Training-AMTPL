using System;

namespace BridgeLabzConsoleApp.Basics.arrayproblems
{
    public class FindDuplicatesInArray
    {
        public static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 4, 5, 1, 4, 6, 5, 6 };

            Console.Write("Duplicate elements: ");

            for (int i = 0; i < numbers.Length; i++)
            {
                bool printed = false;

                for (int j = 0; j < numbers.Length; j++)
                {
                    // Skip comparing the number with itself
                    if (i == j)
                        continue;

                    // If we already printed this number before, skip
                    if (j < i && numbers[i] == numbers[j])
                    {
                        printed = true;
                        break;
                    }

                    // If a duplicate exists ahead, print it
                    if (!printed && j > i && numbers[i] == numbers[j])
                    {
                        Console.Write(numbers[i] + " ");
                        printed = true;
                        break;
                    }
                }
            }
        }
    }
}
