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
            string expected = "gnitseT";
            string result = string.Empty;

            LINQEncrypt linqEncryptator = new LINQEncrypt();
            result = linqEncryptator.Encrypt(actual);

            Assert.AreEqual(expected, result);
        }
    }
}
