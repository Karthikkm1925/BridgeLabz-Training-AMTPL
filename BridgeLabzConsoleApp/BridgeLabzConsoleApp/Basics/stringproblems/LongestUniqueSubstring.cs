using System;

namespace BridgeLabzConsoleApp.Basics.stringproblems
{
    public class LongestUniqueSubstring
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            int maxLength = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string sub = "";
                for (int j = i; j < input.Length; j++)
                {
                    char ch = input[j];

                    // Check if this char already exists in substring
                    bool isDuplicate = false;
                    for (int k = 0; k < sub.Length; k++)
                    {
                        if (sub[k] == ch)
                        {
                            isDuplicate = true;
                            break;
                        }
                    }

                    if (isDuplicate)
                        break;
                    else
                        sub += ch;

                    if (sub.Length > maxLength)
                        maxLength = sub.Length;
                }
            }

            Console.WriteLine("Length of longest substring without repeating characters: " + maxLength);
        }
    }
}
