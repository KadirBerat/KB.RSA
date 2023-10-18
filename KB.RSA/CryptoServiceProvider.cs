using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KB.RSA
{
    public class CryptoServiceProvider
    {
        /// <summary>
        /// NS: Not Secure
        /// Rec: Recommended
        /// SEC: Secure
        /// App: Applicable
        /// NR: Not Recommended
        /// </summary>
        public enum RSAKeySize
        {
            RSA_1024_NS = 1024,
            RSA_2048_Sec = 2048,
            RSA_3072_Rec = 3072,
            RSA_4096_Rec = 4096,
            RSA_5120_Sec = 5120,
            RSA_6144_Sec = 6144,
            RSA_7168_App = 7168,
            RSA_8192_App = 8192,
            RSA_9216_NR = 9216,
            RSA_10240_NR = 10240,
            RSA_12288_NR = 12288,
            RSA_14336_NR = 14336,
            RSA_16384_NR = 16384
        }

        public void GenerateKey(string savePath) //RSA_3072_Rec
        {
            GenerateKeyRSA gkRSA = new GenerateKeyRSA(savePath);
            gkRSA.GenerateKey();
        }

        public void GenerateKey(string savePath, RSAKeySize keySize)
        {
            GenerateKeyRSA gkRSA = new GenerateKeyRSA(savePath, keySize);
            gkRSA.GenerateKey();
        }

        public string Encrypt(string publicKeyPath, string plainText)
        {
            string publickey = File.ReadAllText(publicKeyPath);
            EncryptRSA eRSA = new EncryptRSA(publickey);
            return eRSA.Encrypt(plainText);
        }

        public string Decrypt(string privateKeyPath, string cipherText)
        {
            string privatekey = File.ReadAllText(privateKeyPath);
            DecryptRSA dRSA = new DecryptRSA(privatekey);
            return dRSA.Decrypt(cipherText);
        }

    }
}
