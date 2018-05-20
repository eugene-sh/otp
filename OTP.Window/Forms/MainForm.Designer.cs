namespace OTP.Window
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
			this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.encryptTab = new System.Windows.Forms.TabPage();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.ownKeyTextBox = new System.Windows.Forms.TextBox();
			this.useOwnKey = new System.Windows.Forms.CheckBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.importFromFileGroupBox = new System.Windows.Forms.GroupBox();
			this.encryptStreamButton = new System.Windows.Forms.Button();
			this.searchSourceFileButton = new System.Windows.Forms.Button();
			this.pathToSourceFileTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.realTimeGroupBox = new System.Windows.Forms.GroupBox();
			this.encryptButton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.encryptedTextbox = new System.Windows.Forms.TextBox();
			this.encryptSourceTextbox = new System.Windows.Forms.TextBox();
			this.decryptTab = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.decryptButton = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.decryptedTextbox = new System.Windows.Forms.TextBox();
			this.decryptSourceTextbox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.mainMenuStrip.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.encryptTab.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.importFromFileGroupBox.SuspendLayout();
			this.realTimeGroupBox.SuspendLayout();
			this.decryptTab.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenuStrip
			// 
			this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.помощьToolStripMenuItem});
			this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.mainMenuStrip.Name = "mainMenuStrip";
			this.mainMenuStrip.Size = new System.Drawing.Size(805, 24);
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
			this.tabControl1.Location = new System.Drawing.Point(12, 27);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(782, 524);
			this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.tabControl1.TabIndex = 1;
			// 
			// encryptTab
			// 
			this.encryptTab.Controls.Add(this.groupBox4);
			this.encryptTab.Controls.Add(this.groupBox3);
			this.encryptTab.Location = new System.Drawing.Point(4, 34);
			this.encryptTab.Name = "encryptTab";
			this.encryptTab.Padding = new System.Windows.Forms.Padding(10);
			this.encryptTab.Size = new System.Drawing.Size(774, 486);
			this.encryptTab.TabIndex = 0;
			this.encryptTab.Text = "Шифрование";
			this.encryptTab.UseVisualStyleBackColor = true;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.ownKeyTextBox);
			this.groupBox4.Controls.Add(this.useOwnKey);
			this.groupBox4.Location = new System.Drawing.Point(13, 13);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(358, 102);
			this.groupBox4.TabIndex = 11;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Настройки";
			// 
			// ownKeyTextBox
			// 
			this.ownKeyTextBox.Location = new System.Drawing.Point(22, 53);
			this.ownKeyTextBox.Name = "ownKeyTextBox";
			this.ownKeyTextBox.ReadOnly = true;
			this.ownKeyTextBox.Size = new System.Drawing.Size(308, 20);
			this.ownKeyTextBox.TabIndex = 7;
			// 
			// useOwnKey
			// 
			this.useOwnKey.AutoSize = true;
			this.useOwnKey.Location = new System.Drawing.Point(22, 30);
			this.useOwnKey.Name = "useOwnKey";
			this.useOwnKey.Size = new System.Drawing.Size(227, 17);
			this.useOwnKey.TabIndex = 9;
			this.useOwnKey.Text = "Использовать свой ключь шифрования";
			this.useOwnKey.UseVisualStyleBackColor = true;
			this.useOwnKey.CheckedChanged += new System.EventHandler(this.useOwnKey_CheckedChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.importFromFileGroupBox);
			this.groupBox3.Controls.Add(this.realTimeGroupBox);
			this.groupBox3.Location = new System.Drawing.Point(13, 121);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(751, 359);
			this.groupBox3.TabIndex = 10;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Шифрование";
			// 
			// importFromFileGroupBox
			// 
			this.importFromFileGroupBox.Controls.Add(this.encryptStreamButton);
			this.importFromFileGroupBox.Controls.Add(this.searchSourceFileButton);
			this.importFromFileGroupBox.Controls.Add(this.pathToSourceFileTextBox);
			this.importFromFileGroupBox.Controls.Add(this.label1);
			this.importFromFileGroupBox.Location = new System.Drawing.Point(388, 28);
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
			// 
			// searchSourceFileButton
			// 
			this.searchSourceFileButton.Image = global::OTP.Window.Properties.Resources.search;
			this.searchSourceFileButton.Location = new System.Drawing.Point(323, 37);
			this.searchSourceFileButton.Name = "searchSourceFileButton";
			this.searchSourceFileButton.Size = new System.Drawing.Size(28, 23);
			this.searchSourceFileButton.TabIndex = 2;
			this.searchSourceFileButton.UseVisualStyleBackColor = true;
			// 
			// pathToSourceFileTextBox
			// 
			this.pathToSourceFileTextBox.Location = new System.Drawing.Point(11, 39);
			this.pathToSourceFileTextBox.Name = "pathToSourceFileTextBox";
			this.pathToSourceFileTextBox.Size = new System.Drawing.Size(304, 20);
			this.pathToSourceFileTextBox.TabIndex = 1;
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
			this.realTimeGroupBox.Controls.Add(this.encryptButton);
			this.realTimeGroupBox.Controls.Add(this.label3);
			this.realTimeGroupBox.Controls.Add(this.label2);
			this.realTimeGroupBox.Controls.Add(this.encryptedTextbox);
			this.realTimeGroupBox.Controls.Add(this.encryptSourceTextbox);
			this.realTimeGroupBox.Location = new System.Drawing.Point(6, 28);
			this.realTimeGroupBox.Name = "realTimeGroupBox";
			this.realTimeGroupBox.Size = new System.Drawing.Size(376, 312);
			this.realTimeGroupBox.TabIndex = 1;
			this.realTimeGroupBox.TabStop = false;
			this.realTimeGroupBox.Text = "Из инпутов";
			// 
			// encryptButton
			// 
			this.encryptButton.Location = new System.Drawing.Point(12, 279);
			this.encryptButton.Name = "encryptButton";
			this.encryptButton.Size = new System.Drawing.Size(109, 23);
			this.encryptButton.TabIndex = 4;
			this.encryptButton.Text = "Зашифровать";
			this.encryptButton.UseVisualStyleBackColor = true;
			this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
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
			// encryptedTextbox
			// 
			this.encryptedTextbox.Location = new System.Drawing.Point(11, 176);
			this.encryptedTextbox.Multiline = true;
			this.encryptedTextbox.Name = "encryptedTextbox";
			this.encryptedTextbox.Size = new System.Drawing.Size(350, 97);
			this.encryptedTextbox.TabIndex = 1;
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
			this.decryptTab.Controls.Add(this.groupBox1);
			this.decryptTab.Controls.Add(this.groupBox2);
			this.decryptTab.Location = new System.Drawing.Point(4, 34);
			this.decryptTab.Name = "decryptTab";
			this.decryptTab.Padding = new System.Windows.Forms.Padding(3);
			this.decryptTab.Size = new System.Drawing.Size(774, 486);
			this.decryptTab.TabIndex = 1;
			this.decryptTab.Text = "Дешифрование";
			this.decryptTab.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Location = new System.Drawing.Point(15, 17);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(358, 102);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Настройки";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(22, 53);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(308, 20);
			this.textBox3.TabIndex = 7;
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new System.Drawing.Point(22, 30);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(227, 17);
			this.checkBox2.TabIndex = 9;
			this.checkBox2.Text = "Использовать свой ключь шифрования";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.groupBox5);
			this.groupBox2.Controls.Add(this.groupBox6);
			this.groupBox2.Location = new System.Drawing.Point(15, 127);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(751, 359);
			this.groupBox2.TabIndex = 12;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Дешифрование";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.button1);
			this.groupBox5.Controls.Add(this.button2);
			this.groupBox5.Controls.Add(this.button3);
			this.groupBox5.Controls.Add(this.textBox4);
			this.groupBox5.Controls.Add(this.label4);
			this.groupBox5.Location = new System.Drawing.Point(388, 28);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Padding = new System.Windows.Forms.Padding(5);
			this.groupBox5.Size = new System.Drawing.Size(359, 170);
			this.groupBox5.TabIndex = 0;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Из файла";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(12, 65);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(109, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Дешифровать";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Image = global::OTP.Window.Properties.Resources.search;
			this.button3.Location = new System.Drawing.Point(323, 37);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(28, 23);
			this.button3.TabIndex = 2;
			this.button3.UseVisualStyleBackColor = true;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(11, 39);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(304, 20);
			this.textBox4.TabIndex = 1;
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
			this.groupBox6.Location = new System.Drawing.Point(6, 28);
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
			this.decryptButton.Click += new System.EventHandler(this.button4_Click);
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
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 116);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(339, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Получить зашифрованный текст";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(805, 566);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.mainMenuStrip);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.mainMenuStrip;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cryptographer";
			this.mainMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.encryptTab.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.importFromFileGroupBox.ResumeLayout(false);
			this.importFromFileGroupBox.PerformLayout();
			this.realTimeGroupBox.ResumeLayout(false);
			this.realTimeGroupBox.PerformLayout();
			this.decryptTab.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
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
		private System.Windows.Forms.Button searchSourceFileButton;
		private System.Windows.Forms.TextBox pathToSourceFileTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button encryptStreamButton;
		private System.Windows.Forms.Button encryptButton;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox encryptedTextbox;
		private System.Windows.Forms.TextBox encryptSourceTextbox;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox ownKeyTextBox;
		private System.Windows.Forms.CheckBox useOwnKey;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Button decryptButton;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox decryptedTextbox;
		private System.Windows.Forms.TextBox decryptSourceTextbox;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.Button button1;
	}
}

