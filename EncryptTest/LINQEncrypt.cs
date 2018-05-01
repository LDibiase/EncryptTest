using System;
using System.Linq;
using Microsoft.SqlServer.Server;

namespace EncryptTest
{
    public class LINQEncrypt : IEncrypt
    {
        public string Encrypt(string stringToEncrypt)
        {
            return new string(stringToEncrypt.ToCharArray().Reverse().ToArray());
        }

        public string Decrypt(string stringToDecrypt)
        {
            return Encrypt(stringToDecrypt);
        }

    }
}