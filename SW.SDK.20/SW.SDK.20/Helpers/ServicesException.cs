using System;
using Newtonsoft.Json;

namespace SW.SDK.Helpers
{
    internal class ServicesException : Exception
    {
        public ServicesException()
        {
        }

        public ServicesException(string message)
            : base(message)
        {
        }

        public ServicesException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
