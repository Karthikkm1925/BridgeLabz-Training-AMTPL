using System;

namespace BridgeLabzConsoleApp.oops.exceptions
{
    public class ExceptionDemo1
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Outer Try Start");

                try
                {
                    Console.WriteLine("Inner Try Start");
                    Console.WriteLine("Enter any number ");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Inner Try End");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Inner Catch: FormatException");
                }
                finally
                {
                    Console.WriteLine("Inner Finally");
                }

            string s = "StringLengthAttribute";
            Console.WriteLine(s.Length);

            Console.WriteLine("Outer Try End");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Outer Catch: NullReferenceException");
            }
            catch (Exception)
            {
                Console.WriteLine("Outer Catch: Other Exception");
            }
            finally
            {
                Console.WriteLine("Outer Finally");
            }

            Console.WriteLine("After Everything Program End");
        }

    }
}
