using System;
using System.Collections.Generic;

namespace BridgeLabzConsoleApp.oops.exceptions
{
    public class SimpleExceptionDemo2
    {
        static void Main(string[] args)
        {
            try
            {
                int x = int.Parse("abc");
            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException");
            }

            try
            {
                int[] a = new int[2];
                Console.WriteLine(a[5]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("IndexOutOfRangeException");
            }
 
            try
            {
                int y = 10;
                int z = y / 0;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("DivideByZeroException");
            }

            try
            {
                List<int> list = new List<int>();
                int n = list[1];
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("ArgumentOutOfRangeException");
            }

            try
            {
                string t = "hello";
                char c = t[100];
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("IndexOutOfRangeException");
            }

            try
            {
                object obj = "hello";
                int k = (int)obj;
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("InvalidCastException");
            }

            try
            {
                var v = new int[100000000000];
            }
            catch (OverflowException)
            {
                Console.WriteLine("OverflowException");
            }
            try
            {
                throw new SystemException();
            }
            catch (SystemException)
            {
                Console.WriteLine("SystemException");
            }
        }
    }
}
