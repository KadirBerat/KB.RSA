using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KB.RSA
{
    internal class DecryptRSA
    {
        private string privatekey = String.Empty;
        internal DecryptRSA(string privatekey)
        {
            this.privatekey = privatekey;
        }
        internal string Decrypt(string cipherText)
        {
            using (System.Security.Cryptography.RSA rsa = System.Security.Cryptography.RSA.Create())
            {
                rsa.ImportFromPem(privatekey.ToCharArray());
                byte[] data = rsa.Decrypt(GetBytesB64(cipherText), RSAEncryptionPadding.OaepSHA384);
                return GetString(data);
            }
        }
        private byte[] GetBytesB64(string data)
        {
            return Convert.FromBase64String(data);
        }
        private string GetString(byte[] data)
        {
            return Encoding.UTF8.GetString(data);
        }
    }
}
