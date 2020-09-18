using System;
using System.Collections.Generic;
using System.Text;

namespace sCTNSolution.Utilities.Exceptions
{
    class sCTNSolutionException : Exception
    {
        public sCTNSolutionException()
        {
        }

        public sCTNSolutionException(string message)
            : base(message)
        {
        }

        public sCTNSolutionException(string message, Exception inner)
            : base(message, inner)
        {
        }
    
    }
}
