namespace OTP.Window
{
	partial class CryptographerForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CryptographerForm));
			this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.encryptTab = new System.Windows.Forms.TabPage();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.importFromFileGroupBox = new System.Windows.Forms.GroupBox();
			this.encryptStreamButton = new System.Windows.Forms.Button();
			this.searchSourceFileToEncryptButton = new System.Windows.Forms.Button();
			this.pathToEncryptedFileTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.realTimeGroupBox = new System.Windows.Forms.GroupBox();
			this.encryptFromInputButton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.encryptTargetTextbox = new System.Windows.Forms.TextBox();
			this.encryptSourceTextbox = new System.Windows.Forms.TextBox();
			this.decryptTab = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.dencryptStreamButton = new System.Windows.Forms.Button();
			this.searchSourceFileToDencryptButton = new System.Windows.Forms.Button();
			this.pathToDecryptedFileTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.decryptButton = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.decryptedTextbox = new System.Windows.Forms.TextBox();
			this.decryptSourceTextbox = new System.Windows.Forms.TextBox();
			this.openFileDialogEncrypt = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialogEncrypt = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialogDecrypt = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialogDecrypt = new System.Windows.Forms.SaveFileDialog();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.keyTextBox = new System.Windows.Forms.TextBox();
			this.ownEncryptKeyCheckBox = new System.Windows.Forms.CheckBox();
			this.mainMenuStrip.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.encryptTab.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.importFromFileGroupBox.SuspendLayout();
			this.realTimeGroupBox.SuspendLayout();
			this.decryptTab.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenuStrip
			// 
			this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.помощьToolStripMenuItem});
			this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.mainMenuStrip.Name = "mainMenuStrip";
			this.mainMenuStrip.Size = new System.Drawing.Size(817, 24);
			this.mainMenuStrip.TabIndex = 0;
			this.mainMenuStrip.Text = "menuStrip1";
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
			this.оПрограммеToolStripMenuItem.Image = global::OTP.Window.Properties.Resources.about;
			this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
			this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.оПрограммеToolStripMenuItem.Text = "О Программе";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.encryptTab);
			this.tabControl1.Controls.Add(this.decryptTab);
			this.tabControl1.ItemSize = new System.Drawing.Size(389, 30);
			this.tabControl1.Location = new System.Drawing.Point(18, 145);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(782, 420);
			this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.tabControl1.TabIndex = 1;
			// 
			// encryptTab
			// 
			this.encryptTab.Controls.Add(this.groupBox3);
			this.encryptTab.Location = new System.Drawing.Point(4, 34);
			this.encryptTab.Name = "encryptTab";
			this.encryptTab.Padding = new System.Windows.Forms.Padding(10);
			this.encryptTab.Size = new System.Drawing.Size(774, 382);
			this.encryptTab.TabIndex = 0;
			this.encryptTab.Text = "Шифрование";
			this.encryptTab.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.importFromFileGroupBox);
			this.groupBox3.Controls.Add(this.realTimeGroupBox);
			this.groupBox3.Location = new System.Drawing.Point(10, 10);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(751, 359);
			this.groupBox3.TabIndex = 10;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Шифрование";
			// 
			// importFromFileGroupBox
			// 
			this.importFromFileGroupBox.Controls.Add(this.encryptStreamButton);
			this.importFromFileGroupBox.Controls.Add(this.searchSourceFileToEncryptButton);
			this.importFromFileGroupBox.Controls.Add(this.pathToEncryptedFileTextBox);
			this.importFromFileGroupBox.Controls.Add(this.label1);
			this.importFromFileGroupBox.Location = new System.Drawing.Point(388, 26);
			this.importFromFileGroupBox.Name = "importFromFileGroupBox";
			this.importFromFileGroupBox.Padding = new System.Windows.Forms.Padding(5);
			this.importFromFileGroupBox.Size = new System.Drawing.Size(359, 100);
			this.importFromFileGroupBox.TabIndex = 0;
			this.importFromFileGroupBox.TabStop = false;
			this.importFromFileGroupBox.Text = "Из файла";
			// 
			// encryptStreamButton
			// 
			this.encryptStreamButton.Location = new System.Drawing.Point(12, 65);
			this.encryptStreamButton.Name = "encryptStreamButton";
			this.encryptStreamButton.Size = new System.Drawing.Size(109, 23);
			this.encryptStreamButton.TabIndex = 3;
			this.encryptStreamButton.Text = "Зашифровать";
			this.encryptStreamButton.UseVisualStyleBackColor = true;
			this.encryptStreamButton.Click += new System.EventHandler(this.EncryptStream);
			// 
			// searchSourceFileToEncryptButton
			// 
			this.searchSourceFileToEncryptButton.Image = global::OTP.Window.Properties.Resources.search;
			this.searchSourceFileToEncryptButton.Location = new System.Drawing.Point(323, 37);
			this.searchSourceFileToEncryptButton.Name = "searchSourceFileToEncryptButton";
			this.searchSourceFileToEncryptButton.Size = new System.Drawing.Size(28, 23);
			this.searchSourceFileToEncryptButton.TabIndex = 2;
			this.searchSourceFileToEncryptButton.UseVisualStyleBackColor = true;
			this.searchSourceFileToEncryptButton.Click += new System.EventHandler(this.SearchSourceFileToEncrypt);
			// 
			// pathToEncryptedFileTextBox
			// 
			this.pathToEncryptedFileTextBox.Location = new System.Drawing.Point(11, 39);
			this.pathToEncryptedFileTextBox.Name = "pathToEncryptedFileTextBox";
			this.pathToEncryptedFileTextBox.Size = new System.Drawing.Size(304, 20);
			this.pathToEncryptedFileTextBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Исходный файл";
			// 
			// realTimeGroupBox
			// 
			this.realTimeGroupBox.Controls.Add(this.encryptFromInputButton);
			this.realTimeGroupBox.Controls.Add(this.label3);
			this.realTimeGroupBox.Controls.Add(this.label2);
			this.realTimeGroupBox.Controls.Add(this.encryptTargetTextbox);
			this.realTimeGroupBox.Controls.Add(this.encryptSourceTextbox);
			this.realTimeGroupBox.Location = new System.Drawing.Point(6, 26);
			this.realTimeGroupBox.Name = "realTimeGroupBox";
			this.realTimeGroupBox.Size = new System.Drawing.Size(376, 312);
			this.realTimeGroupBox.TabIndex = 1;
			this.realTimeGroupBox.TabStop = false;
			this.realTimeGroupBox.Text = "Из инпутов";
			// 
			// encryptFromInputButton
			// 
			this.encryptFromInputButton.Location = new System.Drawing.Point(12, 279);
			this.encryptFromInputButton.Name = "encryptFromInputButton";
			this.encryptFromInputButton.Size = new System.Drawing.Size(109, 23);
			this.encryptFromInputButton.TabIndex = 4;
			this.encryptFromInputButton.Text = "Зашифровать";
			this.encryptFromInputButton.UseVisualStyleBackColor = true;
			this.encryptFromInputButton.Click += new System.EventHandler(this.EncryptFormInput);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 160);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(123, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Зашифрованный текст";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Исходный текст";
			// 
			// encryptTargetTextbox
			// 
			this.encryptTargetTextbox.Location = new System.Drawing.Point(11, 176);
			this.encryptTargetTextbox.Multiline = true;
			this.encryptTargetTextbox.Name = "encryptTargetTextbox";
			this.encryptTargetTextbox.Size = new System.Drawing.Size(350, 97);
			this.encryptTargetTextbox.TabIndex = 1;
			// 
			// encryptSourceTextbox
			// 
			this.encryptSourceTextbox.Location = new System.Drawing.Point(12, 42);
			this.encryptSourceTextbox.Multiline = true;
			this.encryptSourceTextbox.Name = "encryptSourceTextbox";
			this.encryptSourceTextbox.Size = new System.Drawing.Size(349, 97);
			this.encryptSourceTextbox.TabIndex = 0;
			// 
			// decryptTab
			// 
			this.decryptTab.Controls.Add(this.groupBox2);
			this.decryptTab.Location = new System.Drawing.Point(4, 34);
			this.decryptTab.Name = "decryptTab";
			this.decryptTab.Padding = new System.Windows.Forms.Padding(3);
			this.decryptTab.Size = new System.Drawing.Size(774, 382);
			this.decryptTab.TabIndex = 1;
			this.decryptTab.Text = "Дешифрование";
			this.decryptTab.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.groupBox5);
			this.groupBox2.Controls.Add(this.groupBox6);
			this.groupBox2.Location = new System.Drawing.Point(10, 10);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(751, 359);
			this.groupBox2.TabIndex = 12;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Дешифрование";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.dencryptStreamButton);
			this.groupBox5.Controls.Add(this.searchSourceFileToDencryptButton);
			this.groupBox5.Controls.Add(this.pathToDecryptedFileTextBox);
			this.groupBox5.Controls.Add(this.label4);
			this.groupBox5.Location = new System.Drawing.Point(388, 26);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Padding = new System.Windows.Forms.Padding(5);
			this.groupBox5.Size = new System.Drawing.Size(359, 273);
			this.groupBox5.TabIndex = 0;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Из файла";
			// 
			// dencryptStreamButton
			// 
			this.dencryptStreamButton.Location = new System.Drawing.Point(12, 65);
			this.dencryptStreamButton.Name = "dencryptStreamButton";
			this.dencryptStreamButton.Size = new System.Drawing.Size(109, 23);
			this.dencryptStreamButton.TabIndex = 3;
			this.dencryptStreamButton.Text = "Дешифровать";
			this.dencryptStreamButton.UseVisualStyleBackColor = true;
			this.dencryptStreamButton.Click += new System.EventHandler(this.DecryptStream);
			// 
			// searchSourceFileToDencryptButton
			// 
			this.searchSourceFileToDencryptButton.Image = global::OTP.Window.Properties.Resources.search;
			this.searchSourceFileToDencryptButton.Location = new System.Drawing.Point(323, 37);
			this.searchSourceFileToDencryptButton.Name = "searchSourceFileToDencryptButton";
			this.searchSourceFileToDencryptButton.Size = new System.Drawing.Size(28, 23);
			this.searchSourceFileToDencryptButton.TabIndex = 2;
			this.searchSourceFileToDencryptButton.UseVisualStyleBackColor = true;
			this.searchSourceFileToDencryptButton.Click += new System.EventHandler(this.SearchTargetFileToDecrypt);
			// 
			// pathToDecryptedFileTextBox
			// 
			this.pathToDecryptedFileTextBox.Location = new System.Drawing.Point(11, 39);
			this.pathToDecryptedFileTextBox.Name = "pathToDecryptedFileTextBox";
			this.pathToDecryptedFileTextBox.Size = new System.Drawing.Size(304, 20);
			this.pathToDecryptedFileTextBox.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 23);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(87, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Исходный файл";
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.decryptButton);
			this.groupBox6.Controls.Add(this.label5);
			this.groupBox6.Controls.Add(this.label6);
			this.groupBox6.Controls.Add(this.decryptedTextbox);
			this.groupBox6.Controls.Add(this.decryptSourceTextbox);
			this.groupBox6.Location = new System.Drawing.Point(6, 26);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(376, 312);
			this.groupBox6.TabIndex = 1;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Из инпутов";
			// 
			// decryptButton
			// 
			this.decryptButton.Location = new System.Drawing.Point(12, 279);
			this.decryptButton.Name = "decryptButton";
			this.decryptButton.Size = new System.Drawing.Size(109, 23);
			this.decryptButton.TabIndex = 4;
			this.decryptButton.Text = "Дешифровать";
			this.decryptButton.UseVisualStyleBackColor = true;
			this.decryptButton.Click += new System.EventHandler(this.DecryptFormInput);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(9, 160);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(123, 13);
			this.label5.TabIndex = 3;
			this.label5.Text = "Зашифрованный текст";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(9, 26);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(89, 13);
			this.label6.TabIndex = 2;
			this.label6.Text = "Исходный текст";
			// 
			// decryptedTextbox
			// 
			this.decryptedTextbox.Location = new System.Drawing.Point(11, 176);
			this.decryptedTextbox.Multiline = true;
			this.decryptedTextbox.Name = "decryptedTextbox";
			this.decryptedTextbox.Size = new System.Drawing.Size(350, 97);
			this.decryptedTextbox.TabIndex = 1;
			// 
			// decryptSourceTextbox
			// 
			this.decryptSourceTextbox.Location = new System.Drawing.Point(12, 42);
			this.decryptSourceTextbox.Multiline = true;
			this.decryptSourceTextbox.Name = "decryptSourceTextbox";
			this.decryptSourceTextbox.Size = new System.Drawing.Size(349, 97);
			this.decryptSourceTextbox.TabIndex = 0;
			// 
			// openFileDialogEncrypt
			// 
			this.openFileDialogEncrypt.FileName = "openFileDialog1";
			this.openFileDialogEncrypt.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
			this.openFileDialogEncrypt.FilterIndex = 2;
			this.openFileDialogEncrypt.InitialDirectory = "c:\\\\";
			this.openFileDialogEncrypt.RestoreDirectory = true;
			// 
			// saveFileDialogEncrypt
			// 
			this.saveFileDialogEncrypt.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
			this.saveFileDialogEncrypt.FilterIndex = 2;
			// 
			// openFileDialogDecrypt
			// 
			this.openFileDialogDecrypt.FileName = "openFileDialog1";
			this.openFileDialogDecrypt.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
			this.openFileDialogDecrypt.FilterIndex = 2;
			this.openFileDialogDecrypt.InitialDirectory = "c:\\\\";
			this.openFileDialogDecrypt.RestoreDirectory = true;
			// 
			// saveFileDialogDecrypt
			// 
			this.saveFileDialogDecrypt.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
			this.saveFileDialogDecrypt.FilterIndex = 2;
			this.saveFileDialogDecrypt.RestoreDirectory = true;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.keyTextBox);
			this.groupBox4.Controls.Add(this.ownEncryptKeyCheckBox);
			this.groupBox4.Location = new System.Drawing.Point(18, 37);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(778, 102);
			this.groupBox4.TabIndex = 12;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Настройки";
			// 
			// keyTextBox
			// 
			this.keyTextBox.Location = new System.Drawing.Point(22, 53);
			this.keyTextBox.MaxLength = 256;
			this.keyTextBox.Name = "keyTextBox";
			this.keyTextBox.ReadOnly = true;
			this.keyTextBox.Size = new System.Drawing.Size(739, 20);
			this.keyTextBox.TabIndex = 7;
			// 
			// ownEncryptKeyCheckBox
			// 
			this.ownEncryptKeyCheckBox.AutoSize = true;
			this.ownEncryptKeyCheckBox.Location = new System.Drawing.Point(22, 30);
			this.ownEncryptKeyCheckBox.Name = "ownEncryptKeyCheckBox";
			this.ownEncryptKeyCheckBox.Size = new System.Drawing.Size(227, 17);
			this.ownEncryptKeyCheckBox.TabIndex = 9;
			this.ownEncryptKeyCheckBox.Text = "Использовать свой ключь шифрования";
			this.ownEncryptKeyCheckBox.UseVisualStyleBackColor = true;
			this.ownEncryptKeyCheckBox.CheckedChanged += new System.EventHandler(this.ShouldUseOwnKey);
			// 
			// CryptographerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(817, 566);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.mainMenuStrip);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.mainMenuStrip;
			this.MaximizeBox = false;
			this.Name = "CryptographerForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cryptographer";
			this.mainMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.encryptTab.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.importFromFileGroupBox.ResumeLayout(false);
			this.importFromFileGroupBox.PerformLayout();
			this.realTimeGroupBox.ResumeLayout(false);
			this.realTimeGroupBox.PerformLayout();
			this.decryptTab.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip mainMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage encryptTab;
		private System.Windows.Forms.TabPage decryptTab;
		private System.Windows.Forms.GroupBox realTimeGroupBox;
		private System.Windows.Forms.GroupBox importFromFileGroupBox;
		private System.Windows.Forms.Button searchSourceFileToEncryptButton;
		private System.Windows.Forms.TextBox pathToEncryptedFileTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button encryptStreamButton;
		private System.Windows.Forms.Button encryptFromInputButton;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox encryptTargetTextbox;
		private System.Windows.Forms.TextBox encryptSourceTextbox;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Button dencryptStreamButton;
		private System.Windows.Forms.Button searchSourceFileToDencryptButton;
		private System.Windows.Forms.TextBox pathToDecryptedFileTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Button decryptButton;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox decryptedTextbox;
		private System.Windows.Forms.TextBox decryptSourceTextbox;
		private System.Windows.Forms.OpenFileDialog openFileDialogEncrypt;
		private System.Windows.Forms.SaveFileDialog saveFileDialogEncrypt;
		private System.Windows.Forms.OpenFileDialog openFileDialogDecrypt;
		private System.Windows.Forms.SaveFileDialog saveFileDialogDecrypt;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox keyTextBox;
		private System.Windows.Forms.CheckBox ownEncryptKeyCheckBox;
	}
}

