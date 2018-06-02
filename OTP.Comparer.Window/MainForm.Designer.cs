namespace OTP.Comparer.Window
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.searchTargetTextButton = new System.Windows.Forms.Button();
			this.pathToTargetTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.compareFromFileButton = new System.Windows.Forms.Button();
			this.searchSourceTextButton = new System.Windows.Forms.Button();
			this.pathToSourceFileTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.compareFromInput = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.targetTextBox = new System.Windows.Forms.TextBox();
			this.sourceTextBox = new System.Windows.Forms.TextBox();
			this.openFileDialogCompare = new System.Windows.Forms.OpenFileDialog();
			this.menuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.помощьToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(373, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// выходToolStripMenuItem
			// 
			this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
			this.выходToolStripMenuItem.Text = "Выход";
			// 
			// помощьToolStripMenuItem
			// 
			this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
			this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
			this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
			this.помощьToolStripMenuItem.Text = "Помощь";
			// 
			// оПрограммеToolStripMenuItem
			// 
			this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
			this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.оПрограммеToolStripMenuItem.Text = "О Программе";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.searchTargetTextButton);
			this.groupBox1.Controls.Add(this.pathToTargetTextBox);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.compareFromFileButton);
			this.groupBox1.Controls.Add(this.searchSourceTextButton);
			this.groupBox1.Controls.Add(this.pathToSourceFileTextBox);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 27);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(348, 186);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Из файла";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(15, 85);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(129, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Расшифрованный текст";
			// 
			// searchTargetTextButton
			// 
			this.searchTargetTextButton.Image = global::OTP.Comparer.Window.Properties.Resources.search;
			this.searchTargetTextButton.Location = new System.Drawing.Point(305, 105);
			this.searchTargetTextButton.Name = "searchTargetTextButton";
			this.searchTargetTextButton.Size = new System.Drawing.Size(28, 23);
			this.searchTargetTextButton.TabIndex = 10;
			this.searchTargetTextButton.UseVisualStyleBackColor = true;
			this.searchTargetTextButton.Click += new System.EventHandler(this.searchTargetTextButton_Click);
			// 
			// pathToTargetTextBox
			// 
			this.pathToTargetTextBox.Location = new System.Drawing.Point(18, 106);
			this.pathToTargetTextBox.Name = "pathToTargetTextBox";
			this.pathToTargetTextBox.Size = new System.Drawing.Size(281, 20);
			this.pathToTargetTextBox.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Исходный текст";
			// 
			// compareFromFileButton
			// 
			this.compareFromFileButton.Location = new System.Drawing.Point(18, 143);
			this.compareFromFileButton.Name = "compareFromFileButton";
			this.compareFromFileButton.Size = new System.Drawing.Size(109, 23);
			this.compareFromFileButton.TabIndex = 7;
			this.compareFromFileButton.Text = "Сравнить";
			this.compareFromFileButton.UseVisualStyleBackColor = true;
			this.compareFromFileButton.Click += new System.EventHandler(this.compareFromFileButton_Click);
			// 
			// searchSourceTextButton
			// 
			this.searchSourceTextButton.Image = global::OTP.Comparer.Window.Properties.Resources.search;
			this.searchSourceTextButton.Location = new System.Drawing.Point(305, 53);
			this.searchSourceTextButton.Name = "searchSourceTextButton";
			this.searchSourceTextButton.Size = new System.Drawing.Size(28, 23);
			this.searchSourceTextButton.TabIndex = 6;
			this.searchSourceTextButton.UseVisualStyleBackColor = true;
			this.searchSourceTextButton.Click += new System.EventHandler(this.searchSourceTextButton_Click);
			// 
			// pathToSourceFileTextBox
			// 
			this.pathToSourceFileTextBox.Location = new System.Drawing.Point(18, 54);
			this.pathToSourceFileTextBox.Name = "pathToSourceFileTextBox";
			this.pathToSourceFileTextBox.Size = new System.Drawing.Size(281, 20);
			this.pathToSourceFileTextBox.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 13);
			this.label1.TabIndex = 4;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.compareFromInput);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.targetTextBox);
			this.groupBox2.Controls.Add(this.sourceTextBox);
			this.groupBox2.Location = new System.Drawing.Point(18, 230);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(342, 321);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Из полей ввода";
			// 
			// compareFromInput
			// 
			this.compareFromInput.Location = new System.Drawing.Point(12, 283);
			this.compareFromInput.Name = "compareFromInput";
			this.compareFromInput.Size = new System.Drawing.Size(109, 23);
			this.compareFromInput.TabIndex = 12;
			this.compareFromInput.Text = "Сравнить";
			this.compareFromInput.UseVisualStyleBackColor = true;
			this.compareFromInput.Click += new System.EventHandler(this.compareFromInput_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 157);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(129, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Расшифрованный текст";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(9, 23);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(89, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "Исходный текст";
			// 
			// targetTextBox
			// 
			this.targetTextBox.Location = new System.Drawing.Point(11, 173);
			this.targetTextBox.Multiline = true;
			this.targetTextBox.Name = "targetTextBox";
			this.targetTextBox.Size = new System.Drawing.Size(317, 97);
			this.targetTextBox.TabIndex = 5;
			// 
			// sourceTextBox
			// 
			this.sourceTextBox.Location = new System.Drawing.Point(12, 39);
			this.sourceTextBox.Multiline = true;
			this.sourceTextBox.Name = "sourceTextBox";
			this.sourceTextBox.Size = new System.Drawing.Size(314, 97);
			this.sourceTextBox.TabIndex = 4;
			// 
			// openFileDialogCompare
			// 
			this.openFileDialogCompare.FileName = "openFileDialog1";
			this.openFileDialogCompare.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
			this.openFileDialogCompare.FilterIndex = 2;
			this.openFileDialogCompare.InitialDirectory = "c:\\\\";
			this.openFileDialogCompare.RestoreDirectory = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(373, 568);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Comparer";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button searchTargetTextButton;
		private System.Windows.Forms.TextBox pathToTargetTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button compareFromFileButton;
		private System.Windows.Forms.Button searchSourceTextButton;
		private System.Windows.Forms.TextBox pathToSourceFileTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button compareFromInput;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox targetTextBox;
		private System.Windows.Forms.TextBox sourceTextBox;
		private System.Windows.Forms.OpenFileDialog openFileDialogCompare;
	}
}

