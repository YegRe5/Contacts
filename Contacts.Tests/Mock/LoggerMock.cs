using Microsoft.Extensions.Logging;
using System;

namespace Sms.Demo.Contacts.Tests
{
    /// <summary>
    /// Mock для репозитория контактов
    /// </summary>
    internal class LoggerMock<T> : ILogger<T>
    {
        #region ILogger

        public IDisposable BeginScope<TState>(TState state)
        {
            return state as IDisposable;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return false;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {

        }

        #endregion
    }
}
