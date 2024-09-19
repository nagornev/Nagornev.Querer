using System;

namespace Nagornev.Querer
{
    public class QuererException : Exception
    {
        public QuererException()
        {
        }

        public QuererException(string message) 
            : base(message)
        {
        }

        public QuererException(string message,
                               Exception innerException) 
            : base(message, innerException)
        {
        }
    }
}
