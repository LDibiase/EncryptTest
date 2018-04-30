namespace EncryptTest
{
    public interface IEncrypt
    {
        string Encrypt(string stringToEncrypt);

        string Decrypt(string stringToDecrypt);
    }
}