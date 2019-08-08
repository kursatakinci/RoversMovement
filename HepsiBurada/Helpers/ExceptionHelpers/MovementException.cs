using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace HepsiBurada.Helpers.ExceptionHelpers
{
    public class MovementException : Exception
    {
        public MovementException() : base()
        {

        }

        public MovementException(string message) : base(message)
        {

        }

        public MovementException(string message, Exception innerException) : base(message, innerException)
        {

        }

        public MovementException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
