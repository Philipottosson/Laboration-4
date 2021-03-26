using System;
using System.Runtime.Serialization;

namespace Labb.ClassLIbary
{
    [Serializable]
    internal class WrongCountException : Exception
    {
        public WrongCountException()
        {
        }

        public WrongCountException(string message) : base(message)
        {
        }

        public WrongCountException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected WrongCountException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}