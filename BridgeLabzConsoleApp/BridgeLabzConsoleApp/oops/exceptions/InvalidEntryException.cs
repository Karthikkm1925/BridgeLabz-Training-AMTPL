using System;

namespace BridgeLabzConsoleApp.oops.exceptions
{
    public class InvalidEntryException : Exception
    {
        public InvalidEntryException(string msg) : base(msg)
        {

        }
    }
}
