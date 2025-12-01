using BridgeLabzConsoleApp.oops.exceptions;
using System;

namespace BridgeLabzConsoleApp.oops.exceptions
{
    public class CustomExceptionDemo
    {
        public static void Main() { 

                Console.WriteLine("Custom Exception Demo ");
            try {
                Console.WriteLine("Enter age of the person");
                int age = Convert.ToInt32(Console.ReadLine());
                
                if (age <= 0)
                {
                     throw new InvalidEntryException("Age must be positive");
                 }
                else if (age > 0 && age< 18)
                {
                    throw new NotEligibleException("Not eligible to vote");
                }
                else
                {
                    Console.WriteLine("You Can Vote");
                }
            }
            catch (InvalidEntryException e) {
                Console.WriteLine(e.Message);
            }
            catch (NotEligibleException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
             
    }
}

