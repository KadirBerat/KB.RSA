using System.Security.Cryptography;

namespace KB.RSA.Models
{
    public class RSAKeyModel
    {
        private RSAParameters? _publicKey = null;
        private RSAParameters? _privateKey = null;

        public RSAParameters? PublicKey { get => _publicKey; set => _publicKey = value; }
        public RSAParameters? PrivateKey { get => _privateKey; set => _privateKey = value; }
    }
}
