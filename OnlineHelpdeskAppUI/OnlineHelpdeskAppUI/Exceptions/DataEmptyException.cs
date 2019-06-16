using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineHelpdeskAppUI.Exceptions
{

    [Serializable]
    public class DataEmptyException : ApplicationException
    {
        public DataEmptyException() { }
        public DataEmptyException(string message) : base(message) { }
        public DataEmptyException(string message, Exception inner) : base(message, inner) { }
        protected DataEmptyException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
   
}
