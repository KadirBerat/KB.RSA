using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KB.RSA
{
    internal class EncryptRSA
    {
        private string publickey = String.Empty;
        internal EncryptRSA(string publickey)
        {
            this.publickey = publickey;
        }
        internal string Encrypt(string plainText)
        {
            using (System.Security.Cryptography.RSA rsa = System.Security.Cryptography.RSA.Create())
            {
                rsa.ImportFromPem(publickey.ToCharArray());
                byte[] data = rsa.Encrypt(GetBytes(plainText), RSAEncryptionPadding.OaepSHA384);
                return GetStringB64(data);
            }
        }
        private byte[] GetBytes(string data)
        {
            return Encoding.UTF8.GetBytes(data);
        }
        private string GetStringB64(byte[] data)
        {
            return Convert.ToBase64String(data);
        }

    }
}
