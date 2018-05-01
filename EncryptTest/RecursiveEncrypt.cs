using System.Xml.XPath;

namespace EncryptTest
{
    public class RecursiveEncrypt : IEncrypt
    {
        public string Encrypt(string stringToEncrypt)
        {
            string result = string.Empty;

            result = StringReverse(stringToEncrypt);
            result = ConcatPhrase(result, "$");

            return result;
        }

        public string Decrypt(string stringToDecrypt)
        {
            string result = string.Empty;

            result = stringToDecrypt.Replace("$", string.Empty);
            result = StringReverse(result);

            return result;
        }

        private string StringReverse(string str)
        {
            if (str.Length > 0)
                return str[str.Length - 1] + StringReverse(str.Substring(0, str.Length - 1));
            else
                return str;
        }

        private string ConcatPhrase(string str, string phrase)
        {
            if (str.Length > 0)
                return str[0] + phrase + ConcatPhrase(str.Remove(0, 1), phrase);
            else
                return str;
        }
    }
}