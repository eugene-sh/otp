using System;
using System.Security.Cryptography;
using System.Text;

namespace OTP.Comparer
{
	public class TextBaseComparer
	{
		public string Data { get; set; }
		public string Hash { get; set; }

		public TextBaseComparer(string text)
		{
			Data = text;
			Hash = CalculateHash(text);
		}

		private string CalculateHash(string text)
		{
			using (var md5 = MD5.Create())
			{
				byte[] inputBytes = Encoding.ASCII.GetBytes(text);
				byte[] hash = md5.ComputeHash(inputBytes);

				return ConvertHashToString(hash);
			}
		}

		private string ConvertHashToString(byte[] hash)
		{
			var hashStringBuilder = new StringBuilder();

			for (int i = 0; i < hash.Length; i++)
			{
				hashStringBuilder.Append(hash[i].ToString("X2"));
			}

			return hashStringBuilder.ToString();
		}

		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				throw new ArgumentNullException(nameof(obj));
			}

			return base.Equals(obj) && HasEquals(obj as TextBaseComparer);
		}

		private bool HasEquals(TextBaseComparer text)
		{
			return MD5.Equals(text.Hash, Hash);
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override string ToString()
		{
			return base.ToString();
		}
	}
}
