using System;
using System.Windows.Forms;

namespace OTP.Comparer.Window
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void CompareFromFileButtonClick(object sender, EventArgs e)
		{
			if (TextBaseComparer.CompareFromStream(pathToSourceFileTextBox.Text, pathToTargetTextBox.Text))
                ShowSuccessMessage();
            else
                ShowErrorMessage();
        }

		private void CompareFromInputClick(object sender, EventArgs e)
		{
			if (TextBaseComparer.Compare(sourceTextBox.Text, targetTextBox.Text))
                ShowSuccessMessage();
            else
                ShowErrorMessage();
		}

		private void ShowSuccessMessage()
		{
			MessageBox.Show("Равны");
		}

		private void ShowErrorMessage()
		{
			MessageBox.Show("Не равны");
		}

		private void SearchSourceTextButtonClick(object sender, EventArgs e)
		{
			if (openFileDialogCompare.ShowDialog() == DialogResult.OK)
                pathToSourceFileTextBox.Text = openFileDialogCompare.FileName;
        }

		private void SearchTargetTextButtonClick(object sender, EventArgs e)
		{
			if (openFileDialogCompare.ShowDialog() == DialogResult.OK)
                pathToTargetTextBox.Text = openFileDialogCompare.FileName;
        }
	}
}
