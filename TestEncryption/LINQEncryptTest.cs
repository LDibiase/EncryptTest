using System;
using EncryptTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestEncryption
{
    [TestClass]
    public class LINQEncryptTest
    {
        [TestMethod]
        public void LINQEncription_OK()
        {
            string actual = "Testing";
            int actualLength = actual.Length;
            
            string result = string.Empty;

            LINQEncrypt linqEncryptator = new LINQEncrypt();
            result = linqEncryptator.Encrypt(actual);

            Assert.AreNotEqual(actualLength, result.Length);
        }
    }
}
