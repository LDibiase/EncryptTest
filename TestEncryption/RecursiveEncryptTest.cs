using System;
using EncryptTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestEncryption
{
    [TestClass]
    public class RecursiveEncryptTest
    {
        [TestMethod]
        public void RecursiveEncription_OK()
        {
            string actual = "Testing";
            string expected = "gnitseT";
            string result = string.Empty;

            RecursiveEncrypt recursiveEncryptor = new RecursiveEncrypt();
            result = recursiveEncryptor.Encrypt(actual);

            Assert.AreEqual(expected, result);
        }
    }
}