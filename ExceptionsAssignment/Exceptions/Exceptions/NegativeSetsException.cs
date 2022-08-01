using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsAssignment.Exceptions
{
    public class NegativeSetsException : Exception
    {
        public NegativeSetsException() { }
        public NegativeSetsException(string message) : base(message) { }
        public NegativeSetsException(string message, Exception inner) : base(message, inner) { }
        protected NegativeSetsException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}

