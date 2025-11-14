using System;

namespace BridgeLabzConsoleApp.Basics.arrayproblems
{
    public class FindMissingNumber
    {
        public static void Main()
        {
            int[] numbers = { 1, 2, 4, 5, 6 };

            int n = numbers.Length + 1; // total numbers if none missing
            int expectedSum = n * (n + 1) / 2;

            int actualSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                actualSum += numbers[i];
            }

            int missingNumber = expectedSum - actualSum;
            Console.WriteLine("Missing number: " + missingNumber);
        }
    }
}
