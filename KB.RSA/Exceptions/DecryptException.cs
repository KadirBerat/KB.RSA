using System.Runtime.Serialization;

namespace KB.RSA.Exceptions
{
    [Serializable]
    public class DecryptException : Exception
    {
        public DecryptException() : base("Decrypt Exception") { }
        public DecryptException(string message) : base(message) { }
        public DecryptException(string message, Exception innerException) : base(message, innerException) { }
        public DecryptException(Exception innerException) : base("Decrypt Exception", innerException) { }
        protected DecryptException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}