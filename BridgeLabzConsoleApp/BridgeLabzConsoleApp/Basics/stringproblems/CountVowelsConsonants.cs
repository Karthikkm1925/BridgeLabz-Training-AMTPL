using System;
 
namespace BridgeLabzConsoleApp.Basics.stringproblems
{
    public class CountVowelsConsonants
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine().ToLower();

            int vowels = 0;
            int consonants = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];

                if (ch >= 'a' && ch <= 'z')
                {
                    if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                        vowels++;
                    else
                        consonants++;
                }
            }

            Console.WriteLine("Vowels: " + vowels);
            Console.WriteLine("Consonants: " + consonants);
        }

        }
    }
