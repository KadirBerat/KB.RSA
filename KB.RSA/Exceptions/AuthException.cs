using System.Runtime.Serialization;

namespace KB.RSA.Exceptions
{
    [Serializable]
    public class AuthException : Exception
    {
        public AuthException() : base("Auth Exception") { }
        public AuthException(string message) : base(message) { }
        public AuthException(string message, Exception innerException) : base(message, innerException) { }
        public AuthException(Exception innerException) : base("Auth Exception", innerException) { }
        protected AuthException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}