using System;

namespace BridgeLabzConsoleApp.Basics.stringproblems
{
    public class FirstNonRepeatingCharacter
    {
        public static void Main()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                bool isUnique = true;

                for (int j = 0; j < input.Length; j++)
                {
                    if (i != j && currentChar == input[j])
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    Console.WriteLine("First non-repeating character: " + currentChar);
                    return;
                }
            }

            Console.WriteLine("No non-repeating character found.");
        }
    }
}
