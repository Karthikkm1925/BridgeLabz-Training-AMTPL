using System;
 
namespace BridgeLabzConsoleApp.oops.exceptions
{
    public class NotEligibleException : Exception
    {
        public NotEligibleException(string msg) : base(msg)
        {
        }
    }
}
