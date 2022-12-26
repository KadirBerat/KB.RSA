namespace KB.RSA.Models
{
    public class ErrorModel
    {
        private string _message = string.Empty;
        private string _operation = string.Empty;
        private string _description = string.Empty;
        private Exception? _error = null;

        public string Message { get => _message; set => _message = value; }
        public string Operation { get => _operation; set => _operation = value; }
        public string Description { get => _description; set => _description = value; }
        public Exception? Error { get => _error; set => _error = value; }
    }
}
