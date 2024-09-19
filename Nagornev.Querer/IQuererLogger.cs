using System;

namespace Nagornev.Querer
{
    public interface IQuererLogger
    {
        void Inform(string message);

        void Warn(string message);

        void Error<TExceptionType>(TExceptionType exception, Func<TExceptionType, string> message)
            where TExceptionType : Exception;
    }
}
