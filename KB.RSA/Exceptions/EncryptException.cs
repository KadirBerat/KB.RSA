using System.Runtime.Serialization;

namespace KB.RSA.Exceptions
{
    [Serializable]
    public class EncryptException : Exception
    {
        public EncryptException() : base("Encrypt Exception") { }
        public EncryptException(string message) : base(message) { }
        public EncryptException(string message, Exception innerException) : base(message, innerException) { }
        public EncryptException(Exception innerException) : base("Encrypt Exception", innerException) { }
        protected EncryptException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
