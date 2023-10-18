using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static KB.RSA.CryptoServiceProvider;

namespace KB.RSA
{
    internal class GenerateKeyRSA
    {
        private string savePath = String.Empty;
        private int keysize = 3072;
        internal GenerateKeyRSA(string savePath)
        {
            this.savePath = savePath;
            this.keysize = 3072;
        }
        internal GenerateKeyRSA(string savePath, RSAKeySize keySize)
        {
            this.savePath = savePath;
            switch (keySize)
            {
                case RSAKeySize.RSA_1024_NS:
                    this.keysize = 1024;
                    break;
                case RSAKeySize.RSA_2048_Sec:
                    this.keysize = 2048;
                    break;
                case RSAKeySize.RSA_3072_Rec:
                    this.keysize = 3072;
                    break;
                case RSAKeySize.RSA_4096_Rec:
                    this.keysize = 4096;
                    break;
                case RSAKeySize.RSA_5120_Sec:
                    this.keysize = 5120;
                    break;
                case RSAKeySize.RSA_6144_Sec:
                    this.keysize = 6144;
                    break;
                case RSAKeySize.RSA_7168_App:
                    this.keysize = 7168;
                    break;
                case RSAKeySize.RSA_8192_App:
                    this.keysize = 8192;
                    break;
                case RSAKeySize.RSA_9216_NR:
                    this.keysize = 9216;
                    break;
                case RSAKeySize.RSA_10240_NR:
                    this.keysize = 10240;
                    break;
                case RSAKeySize.RSA_12288_NR:
                    this.keysize = 12288;
                    break;
                case RSAKeySize.RSA_14336_NR:
                    this.keysize = 14336;
                    break;
                case RSAKeySize.RSA_16384_NR:
                    this.keysize = 16384;
                    break;
                default:
                    this.keysize = 3072;
                    break;
            }
        }
        internal void GenerateKey()
        {
            using (RSACryptoServiceProvider csp = new RSACryptoServiceProvider(keysize))
            {

                string publicKeyPath = $@"{savePath}\publickey.pem";
                string privateKeyPath = $@"{savePath}\privatekey.pem";

                string publickey = csp.ExportRSAPublicKeyPem();
                string privatekey = csp.ExportRSAPrivateKeyPem();


                File.WriteAllText(publicKeyPath, publickey);
                File.WriteAllText(privateKeyPath, privatekey);
            }
        }
    }
}
