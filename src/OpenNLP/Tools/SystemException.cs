using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenNLP.Tools
{
#if !DNF
    public class SystemException : Exception
    {
        public SystemException(string message) : base(message)
        {
            
        }

        public SystemException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
#endif
}
