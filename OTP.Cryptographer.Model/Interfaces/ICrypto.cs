namespace OTP.Cryptographer.Model
{
	public interface ICrypto
	{
		string Encrypt(string key, string plainText);
		string Decrypt(string key, string plainText);
		string EncryptStream(string key, string pathToFile);
		string DecryptStream(string key, string pathToFile);
		string GenerateEncryptionKey(int keyLength);
	}
}
