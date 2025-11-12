using System;
namespace BridgeLabzConsoleApp.Basics.stringproblems
{
    public  class PalindromeCheck
    {

        public static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            int left = 0;
            int right = input.Length - 1;
            bool isPalindrome = true;

            while (left < right)
            {
                if (input[left] != input[right])
                {
                    isPalindrome = false;
                    break;
                }
                left++;
                right--;
            }

            if (isPalindrome)
                Console.WriteLine("The given string is a palindrome.");
            else
                Console.WriteLine("The given string is not a palindrome.");

            Console.ReadLine();  
        }
    }
}
