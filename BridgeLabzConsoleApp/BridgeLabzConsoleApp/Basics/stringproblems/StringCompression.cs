using System;

namespace BridgeLabzConsoleApp.Basics.stringproblems
{
    public class StringCompression
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            string compressed = CompressString(input);
            Console.WriteLine("Compressed string: " + compressed);
        }

        public static string CompressString(string str)
        {
            string result = "";
            int count = 1;

            for (int i = 0; i < str.Length; i++)
            {
                // Check if next char is same
                if (i < str.Length - 1 && str[i] == str[i + 1])
                {
                    count++;
                }
                else
                {
                    // Add current char and its count
                    result = result + str[i] + count;
                    count = 1; // Reset for next character
                }
            }

            return result;
        }
    }
}
