using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.SqlServer.Server;

namespace EncryptTest
{
    public class LINQEncrypt : IEncrypt
    {
        public string Encrypt(string stringToEncrypt)
        {
            StringBuilder sb = new StringBuilder();
            Random rc = new Random();

            stringToEncrypt.ToList().ForEach(x => sb.Append(x).Append(rc.Next(1000, 9999)));

            return sb.ToString();
        }

        public string Decrypt(string stringToDecrypt)
        {
            StringBuilder sb = new StringBuilder();

            var stringSplit = from i in Enumerable.Range(0, stringToDecrypt.Length)
                group stringToDecrypt[i] by i / 5;

            stringSplit.ToList().ForEach(x=>sb.Append(x.ToArray().First()));

            return sb.ToString();
        }
    }
}