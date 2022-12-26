namespace KB.RSA.Models
{
    public class RSAModel
    {
        private bool _result = false;
        private object? _data = null;
        private string _message = string.Empty;

        public bool Result { get => _result; set => _result = value; }
        public object? Data { get=> _data; set => _data = value; }
        public string Message { get => _message; set => _message = value; }
    }
}