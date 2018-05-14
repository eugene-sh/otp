using System;
using System.Windows.Forms;

namespace OTP.Window
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void ClickToEncryptButton(object eventSender, EventArgs eventArgs)
		{
			new EncryptDialog().ShowDialog();
		}
	}
}
