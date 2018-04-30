using System;

namespace EncryptTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            RecursiveEncrypt recursiveEncryptator = new RecursiveEncrypt();
            LINQEncrypt linqEncryptator = new LINQEncrypt();

            var result = "TEST";

            Console.WriteLine(result);
        }
    }
}
