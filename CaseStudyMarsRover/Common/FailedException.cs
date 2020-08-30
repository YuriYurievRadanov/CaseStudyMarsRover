using System;
using System.Runtime.Serialization;

namespace MarsRover.Common
{
    public class FailedException : Exception
    {
        public FailedException()
                : base()
        { }

        public FailedException(string message)
            : base(message)

        { }

        public FailedException(string message, Exception innerException)
            : base(message, innerException)
        { }

        protected FailedException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        { }
    }
}