using System;

namespace EncryptTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            var textToManipulate = "JustTesting";
            
            RecursiveEncrypt recursiveEncryptator = new RecursiveEncrypt();
            LINQEncrypt linqEncryptator = new LINQEncrypt();

            Console.WriteLine("-----------------------LINQ---------------------------");

            Console.WriteLine("The encrypted value for {0} is {1}", textToManipulate, linqEncryptator.Encrypt(textToManipulate));
            Console.WriteLine("The decrypted value for {0} is {1}", linqEncryptator.Encrypt(textToManipulate), linqEncryptator.Decrypt(linqEncryptator.Encrypt(textToManipulate)));

            Console.WriteLine("-----------------------RECURSIVE----------------------");

            Console.WriteLine("The encrypted value for {0} is {1}", textToManipulate, recursiveEncryptator.Encrypt(textToManipulate));
            Console.WriteLine("The decrypted value for {0} is {1}", recursiveEncryptator.Encrypt(textToManipulate), recursiveEncryptator.Decrypt(recursiveEncryptator.Encrypt(textToManipulate)));
        }
    }
}
