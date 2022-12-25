using System.Runtime.Serialization;

namespace KB.RSA.Exceptions
{
    [Serializable]
    public class KeyGenerationException : Exception
    {
        public KeyGenerationException() : base("Key Generation Exception") { }
        public KeyGenerationException(string message) : base(message) { }
        public KeyGenerationException(string message, Exception innerException) : base(message, innerException) { }
        public KeyGenerationException(Exception innerException) : base("Key Generation Exception", innerException) { }
        protected KeyGenerationException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
