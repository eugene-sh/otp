using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace OTP.Cryptographer.Model
{
	public static class Crypto
	{
		private const int NonceLength = 4;
		private static Encoding _encoding => Encoding.GetEncoding(1251);

		public static string Encrypt(string key, string plainText)
		{
			if (string.IsNullOrEmpty(key))
				throw new ArgumentNullException(nameof(key));
			if (string.IsNullOrEmpty(plainText))
				throw new ArgumentNullException(nameof(plainText));

			var nonce = GenerateNonce(NonceLength);
			var plainTextBytes = _encoding.GetBytes(plainText);
			var keyBytes = _encoding.GetBytes(key);

			var decryptedText = nonce.Concat(
				XorCounterModeEncryptDecrypt(keyBytes, plainTextBytes, nonce));

			return _encoding.GetString(decryptedText.ToArray());
		}

		public static string Decrypt(string key, string plainText)
		{
			if (string.IsNullOrEmpty(key))
				throw new ArgumentNullException(nameof(key));
			if (string.IsNullOrEmpty(plainText))
				throw new ArgumentNullException(nameof(plainText));

			var plainTextBytes = _encoding.GetBytes(plainText);
			var keyBytes = _encoding.GetBytes(key);

			var encryptedText = XorCounterModeEncryptDecrypt(
				keyBytes,
				plainTextBytes.Skip(NonceLength).ToArray(),
				plainTextBytes.Take(NonceLength).ToArray());

			return _encoding.GetString(encryptedText.ToArray());
		}

		private static IEnumerable<byte> XorCounterModeEncryptDecrypt(byte[] key, byte[] text, byte[] nonce)
		{
			var roundIndex = 0;
			byte[] roundGamma = null;
			var gammaIndex = 0;

			foreach (var textItem in text)
			{
				if (gammaIndex == 0)
				{
					var counterBlock = nonce.Concat(BitConverter.GetBytes(roundIndex)).ToArray();
					using (var hmacSHA = new HMACSHA512(key))
					{
						roundGamma = hmacSHA.ComputeHash(counterBlock);
					}
				}

				yield return (byte)(textItem ^ roundGamma[gammaIndex]);

				if (gammaIndex < roundGamma.Length - 1)
				{
					gammaIndex++;
				}
				else
				{
					gammaIndex = 0;
					roundIndex++;
				}
			}
		}

		private static byte[] GenerateNonce(int nonceLength)
		{
			byte[] nonce = new byte[nonceLength];

			using (var randomGenerator = new RNGCryptoServiceProvider())
			{
				randomGenerator.GetBytes(nonce);
			}

			return nonce;
		}

		public static string GenerateEncryptionKey(int keyLength)
		{
			var key = new byte[keyLength];
			var encoding = Encoding.GetEncoding(1251);

			using (var randomGenerator = new RNGCryptoServiceProvider())
			{
				randomGenerator.GetBytes(key);
			}

			return encoding.GetString(key);
		}
	}
}
