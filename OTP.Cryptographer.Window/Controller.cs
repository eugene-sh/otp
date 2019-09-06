using System;
using OTP.Cryptographer.Model;

namespace OTP.Window
{
	public class Controller
	{
		public ICrypto Cryptographer { get; }

		public Controller(ICrypto cryptographer)
		{
			Cryptographer = cryptographer ?? throw new ArgumentNullException(nameof(cryptographer));
		}
	}
}
