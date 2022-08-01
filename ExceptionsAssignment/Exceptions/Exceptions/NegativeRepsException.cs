using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsAssignment.Exceptions
{
    public class NegativeRepsException : Exception
    {
        public NegativeRepsException() { }
        public NegativeRepsException(string message) : base(message) { }
        public NegativeRepsException(string message, Exception inner) : base(message, inner) { }
        protected NegativeRepsException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
