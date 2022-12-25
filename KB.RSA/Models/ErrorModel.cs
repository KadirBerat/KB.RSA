namespace KB.RSA.Models
{
    public class ErrorModel
    {
        public string Message { get; set; }
        public string Operation { get; set; }
        public string Description { get; set; }
        public Exception Error { get; set; }
    }
}
