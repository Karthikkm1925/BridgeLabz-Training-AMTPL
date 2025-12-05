using System;

namespace BridgeLabzConsoleApp.dsa
{
    public class LinearSearch
    {
        public static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            Console.WriteLine("Enter the element to search : ");
            int SearchElement = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == SearchElement){Console.WriteLine($"Element is found at index : {i}");}
            }
            Console.WriteLine("Element Not Found");
        }
    }
}
