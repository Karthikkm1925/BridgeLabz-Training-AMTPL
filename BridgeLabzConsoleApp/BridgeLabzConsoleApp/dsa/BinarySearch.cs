using System;

namespace BridgeLabzConsoleApp.dsa
{
    public class BinarySearch
    {
        public static void Main()
        {
            int[] array = { 1,2,3,4,5,6,7,8,9};
            int search = 8;

            Search(array,search);
        }

        public static void Search(int[] array, int search)
        {
            int li = 0;
            int hi = array.Length - 1;
             
 
            while (li < hi)
            {
                int mid = (li + hi) / 2;
                if (array[mid] == search)
                {
                    Console.WriteLine($"The search element present at index : {mid}");
                    return;
                }
                else if (array[mid] < search)
                {
                    li = mid + 1;
                }
                else
                {
                    hi = mid - 1;
                }
            }
            Console.WriteLine("Search Element not found ");
        }
    }
}
