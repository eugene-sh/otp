using OTP.Cryptographer.Model;
using System;
using System.IO;
using System.Windows.Forms;

namespace OTP.Window
{
	public partial class CryptographerForm : Form
	{
		private readonly int _keyLength;
		private readonly Controller cryptographerController;

		public CryptographerForm(ICrypto cryptographer)
		{
			InitializeComponent();

			cryptographerController = new Controller(cryptographer);
			_keyLength = new Random().Next(256);
		}

		private void EncryptFormInput(object sender, EventArgs e)
		{
			var key = ownEncryptKeyCheckBox.Checked
				? keyTextBox.Text
				: cryptographerController.Cryptographer.GenerateEncryptionKey(_keyLength);

			encryptTargetTextbox.Text =
				cryptographerController.Cryptographer.Encrypt(key, encryptSourceTextbox.Text);

			keyTextBox.Text = key;
		}

		private void DecryptFormInput(object sender, EventArgs e)
		{
			var key = keyTextBox.Text;

			decryptedTextbox.Text =
				cryptographerController.Cryptographer.Decrypt(key, decryptSourceTextbox.Text);
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
				: cryptographerController.Cryptographer.GenerateEncryptionKey(256);

			keyTextBox.Text = key;

			if (saveFileDialogEncrypt.ShowDialog() == DialogResult.OK)
			{
				File.WriteAllText(
					saveFileDialogEncrypt.FileName,
					cryptographerController.Cryptographer.EncryptStream(key, pathToEncryptedFileTextBox.Text));
			}
		}

		private void DecryptStream(object sender, EventArgs e)
		{
			var key = keyTextBox.Text;

			if (saveFileDialogDecrypt.ShowDialog() == DialogResult.OK)
			{
				File.WriteAllText(
					saveFileDialogDecrypt.FileName,
					cryptographerController.Cryptographer.DecryptStream(key, pathToDecryptedFileTextBox.Text));
			}
		}
    }
}
