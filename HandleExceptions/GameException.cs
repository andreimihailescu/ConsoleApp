using System;

namespace HandleExceptions
{
    public class GameException : Exception
    {
        public GameException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
