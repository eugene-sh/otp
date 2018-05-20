using OTP.Cryptographer.Model;
using System;
using System.Text;
using System.Windows.Forms;

namespace OTP.Window
{
	public partial class MainForm : Form
	{
		

		public MainForm()
		{
			InitializeComponent();
		}

		private void encryptButton_Click(object sender, EventArgs e)
		{
			string key = useOwnKey.Checked
				? ownKeyTextBox.Text
				: Crypto.GenerateEncryptionKey(5);

			encryptedTextbox.Text = Crypto.Encrypt(key, encryptSourceTextbox.Text);
			ownKeyTextBox.Text = key;

		}

		private void button4_Click(object sender, EventArgs e)
		{
			string key = ownKeyTextBox.Text;

			decryptedTextbox.Text = Crypto.Decrypt(key, decryptSourceTextbox.Text);
		}

		private void useOwnKey_CheckedChanged(object sender, EventArgs e)
		{
			ownKeyTextBox.ReadOnly = textBox3.ReadOnly = !useOwnKey.Checked;
		}
	}
}
