using System;

namespace Somoy.Repo
{
    public class DbEntityValidationException : Exception
    {
        internal readonly object EntityValidationErrors;

        public DbEntityValidationException()
        {
        }

        public DbEntityValidationException(string message) : base(message)
        {
        }

        public DbEntityValidationException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}