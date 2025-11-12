using System;

namespace BridgeLabzConsoleApp.Basics.stringproblems
{
    public class StringReverse
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            string reversed = ReverseString(input);

            Console.WriteLine($"Reversed string: {reversed}");
            Console.ReadLine();

        }

        static string ReverseString(string str)
        {
            string reversed = "";

            // Loop from last index to first
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed += str[i]; // build the reversed string character by character
            }

            return reversed;
        }
    }
}
