using System;
 
using System.Linq;
 

namespace BridgeLabzConsoleApp.advoops.linq
{
    public class LinqDemo1
    {
        public static void Main()
        {
            int[] array1 = { 1,1,0,0,1,1,0,1,0 };
            
            var copy1 = from i in array1 where i != 0 select i;
            foreach ( var i in copy1)
            {
                Console.Write(i+" ");
            }

            int[] array2 = { 10, 25,0, 40, 45, 48, 58, 52,0, };

            var copy2 = from i in array2 where i >= 0 orderby i descending select i;
        }
    }
}
