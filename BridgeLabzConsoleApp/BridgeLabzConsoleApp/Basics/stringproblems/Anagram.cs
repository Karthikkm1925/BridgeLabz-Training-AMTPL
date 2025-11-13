using System;
namespace BridgeLabzConsoleApp.Basics.stringproblems
{
    public class Anagram
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter first string ");
            string string1 = Console.ReadLine().ToLower();
            Console.WriteLine("Enter second string");
            string string2 = Console.ReadLine().ToLower();

            Boolean result = isAnagram(string1, string2);

            if (result)
            {
                Console.WriteLine("Given strings are Anagrams ");
            }
            else
            {
                Console.WriteLine("Given strings are not Anagrams ");
            }
        }

        public static Boolean isAnagram(string string1,string string2)
        {
            int[] count1 = noOfOccurance(string1);
            int[] count2 = noOfOccurance(string2);
            for (int i = 0; i < count1.Length; i++)
            {
                if (count1[i] != count2[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static int[] noOfOccurance(string str)
        {
            int[] count = new int[26];

            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if(ch>='a' && ch<='z')
                {
                    count[ch - 'a']++;
                }
            }
            return count;
        }
    }
}
