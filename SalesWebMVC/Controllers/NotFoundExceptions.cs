using System;
using System.Runtime.Serialization;

namespace SalesWebMVC.Controllers
{
    [Serializable]
    internal class NotFoundExceptions : Exception
    {
        public NotFoundExceptions()
        {
        }

        public NotFoundExceptions(string message) : base(message)
        {
        }

        public NotFoundExceptions(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotFoundExceptions(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}