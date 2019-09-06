using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace OTP.Comparer
{
	public static class TextBaseComparer
	{
		public static bool Compare(string sourceText, string targetText)
		{
			return CalculateHash(sourceText) == CalculateHash(targetText);
		}

		public static bool CompareFromStream(string pathToSourceText, string pathToTargetText)
		{
			string sourceTextHash;
			string targetTextHash;

			using (var sourceTextReader = File.OpenRead(pathToSourceText))
			using (var targetTextReader = File.OpenRead(pathToTargetText))
			{
				sourceTextHash = CalculateHash(sourceTextReader);
				targetTextHash = CalculateHash(targetTextReader);
            }

			return sourceTextHash == targetTextHash;
		}

		private static string CalculateHash(Stream text)
		{
			using (var md5 = MD5.Create())
			{
				byte[] hash = md5.ComputeHash(text);

                return ConvertHashToString(hash);
			}
		}

		private static string CalculateHash(string text)
		{
			using (var md5 = MD5.Create())
			{
				byte[] inputBytes = Encoding.ASCII.GetBytes(text);
				byte[] hash = md5.ComputeHash(inputBytes);

                return ConvertHashToString(hash);
			}
		}

		private static string ConvertHashToString(byte[] hash)
		{
			var hashStringBuilder = new StringBuilder();

			foreach (var hashItem in hash)
                hashStringBuilder.Append(hashItem.ToString("X2"));

            return hashStringBuilder.ToString();
		}
	}
}
