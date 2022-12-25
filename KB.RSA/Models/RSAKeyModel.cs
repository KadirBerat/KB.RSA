using System.Security.Cryptography;

namespace KB.RSA.Models
{
    public class RSAKeyModel
    {
        public RSAParameters publicKey { get; set; }
        public RSAParameters privateKey { get; set; }
    }
}
