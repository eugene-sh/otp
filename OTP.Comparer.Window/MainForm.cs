using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTP.Comparer.Window
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void compareFromFileButton_Click(object sender, EventArgs e)
		{
			if (TextBaseComparer.CompareFromStream(pathToSourceFileTextBox.Text, pathToTargetTextBox.Text))
			{
				ShowSuccessMessage();
			}
			else
			{
				ShowErrorMessage();
			}
		}

		private void compareFromInput_Click(object sender, EventArgs e)
		{
			if (TextBaseComparer.Compare(sourceTextBox.Text, targetTextBox.Text))
			{
				ShowSuccessMessage();
			}
			else
			{
				ShowErrorMessage();
			}
		}

		private void ShowSuccessMessage()
		{
			MessageBox.Show("Равны");
		}

		private void ShowErrorMessage()
		{
			MessageBox.Show("Не равны");
		}

		private void searchSourceTextButton_Click(object sender, EventArgs e)
		{
			if (openFileDialogCompare.ShowDialog() == DialogResult.OK)
			{
				pathToSourceFileTextBox.Text = openFileDialogCompare.FileName;
			}
		}

		private void searchTargetTextButton_Click(object sender, EventArgs e)
		{
			if (openFileDialogCompare.ShowDialog() == DialogResult.OK)
			{
				pathToTargetTextBox.Text = openFileDialogCompare.FileName;
			}
		}
	}
}
