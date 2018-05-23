using OTP.Cryptographer.Model;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace OTP.Window
{
	public partial class MainForm : Form
	{
		private readonly int KeyLength;

		public MainForm()
		{
			InitializeComponent();

			KeyLength = new Random().Next(10, 100);
		}

		private void EncryptFormInput(object sender, EventArgs e)
		{
			var key = ownEncryptKeyCheckBox.Checked
				? keyTextBox.Text
				: Crypto.GenerateEncryptionKey(KeyLength);

			encryptTargetTextbox.Text =
				Crypto.Encrypt(key, encryptSourceTextbox.Text);

			keyTextBox.Text = key;
		}

		private void DecryptFormInput(object sender, EventArgs e)
		{
			var key = keyTextBox.Text;

			decryptedTextbox.Text =
				Crypto.Decrypt(key, decryptSourceTextbox.Text);
		}

		private void SearchSourceFileToEncrypt(object sender, EventArgs e)
		{
			if (openFileDialogEncrypt.ShowDialog() == DialogResult.OK)
			{
				pathToEncryptedFileTextBox.Text = openFileDialogEncrypt.FileName;
			}
		}

		private void SearchTargetFileToDecrypt(object sender, EventArgs e)
		{
			if (openFileDialogDecrypt.ShowDialog() == DialogResult.OK)
			{
				pathToDecryptedFileTextBox.Text = openFileDialogDecrypt.FileName;
			}
		}

		private void ShouldUseOwnKey(object sender, EventArgs e)
		{
			var isOwnKey = ownEncryptKeyCheckBox.Checked;

			keyTextBox.ReadOnly = !isOwnKey;
		}

		private void EncryptStream(object sender, EventArgs e)
		{
			var key = ownEncryptKeyCheckBox.Checked
				? keyTextBox.Text
				: Crypto.GenerateEncryptionKey(5);

			keyTextBox.Text = key;

			if (saveFileDialogEncrypt.ShowDialog() == DialogResult.OK)
			{
				File.WriteAllText(
					saveFileDialogEncrypt.FileName,
					Crypto.EncryptStream(key, pathToEncryptedFileTextBox.Text));
			}
		}

		private void DecryptStream(object sender, EventArgs e)
		{
			var key = keyTextBox.Text;

			if (saveFileDialogDecrypt.ShowDialog() == DialogResult.OK)
			{
				File.WriteAllText(
					saveFileDialogDecrypt.FileName,
					Crypto.DecryptStream(key, pathToDecryptedFileTextBox.Text));
			}
		}
	}
}
