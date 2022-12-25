using System.Runtime.Serialization;

namespace KB.RSA.Exceptions
{
    [Serializable]
    internal class FileOperationException : Exception
    {
        public FileOperationException() : base("File Operation Exception") { }
        public FileOperationException(string message) : base(message) { }
        public FileOperationException(string message, Exception innerException) : base(message, innerException) { }
        public FileOperationException(Exception innerException) : base("File Operation Exception", innerException) { }
        protected FileOperationException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}