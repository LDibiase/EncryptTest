namespace EncryptTest
{
    public class RecursiveEncrypt : IEncrypt
    {
        public string Encrypt(string stringToEncrypt)
        {
            return StringReverse(stringToEncrypt);
        }

        public string Decrypt(string stringToDecrypt)
        {
            return StringReverse(stringToDecrypt);
        }

        private string StringReverse(string str)
        {
            if (str.Length > 0)
                return str[str.Length - 1] + StringReverse(str.Substring(0, str.Length - 1));
            else
                return str;
        }
    }
}