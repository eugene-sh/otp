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
			this.realTimeGroupBox = new System.Windows.Forms.GroupBox();
			this.importFromFileGroupBox = new System.Windows.Forms.GroupBox();
			this.encryptButton = new System.Windows.Forms.Button();
			this.searchSourceFileButton = new System.Windows.Forms.Button();
			this.pathToSourceFileTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.decryptTab = new System.Windows.Forms.TabPage();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.mainMenuStrip.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.encryptTab.SuspendLayout();
			this.realTimeGroupBox.SuspendLayout();
			this.importFromFileGroupBox.SuspendLayout();
			this.decryptTab.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenuStrip
			// 
			this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.помощьToolStripMenuItem});
			this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.mainMenuStrip.Name = "mainMenuStrip";
			this.mainMenuStrip.Size = new System.Drawing.Size(392, 24);
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
			this.tabControl1.ItemSize = new System.Drawing.Size(182, 30);
			this.tabControl1.Location = new System.Drawing.Point(12, 27);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(368, 506);
			this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.tabControl1.TabIndex = 1;
			// 
			// encryptTab
			// 
			this.encryptTab.Controls.Add(this.realTimeGroupBox);
			this.encryptTab.Controls.Add(this.importFromFileGroupBox);
			this.encryptTab.Location = new System.Drawing.Point(4, 34);
			this.encryptTab.Name = "encryptTab";
			this.encryptTab.Padding = new System.Windows.Forms.Padding(10);
			this.encryptTab.Size = new System.Drawing.Size(360, 468);
			this.encryptTab.TabIndex = 0;
			this.encryptTab.Text = "Шифрование";
			this.encryptTab.UseVisualStyleBackColor = true;
			// 
			// realTimeGroupBox
			// 
			this.realTimeGroupBox.Controls.Add(this.button1);
			this.realTimeGroupBox.Controls.Add(this.label3);
			this.realTimeGroupBox.Controls.Add(this.label2);
			this.realTimeGroupBox.Controls.Add(this.textBox2);
			this.realTimeGroupBox.Controls.Add(this.textBox1);
			this.realTimeGroupBox.Location = new System.Drawing.Point(13, 133);
			this.realTimeGroupBox.Name = "realTimeGroupBox";
			this.realTimeGroupBox.Size = new System.Drawing.Size(334, 322);
			this.realTimeGroupBox.TabIndex = 1;
			this.realTimeGroupBox.TabStop = false;
			this.realTimeGroupBox.Text = "groupBox2";
			// 
			// importFromFileGroupBox
			// 
			this.importFromFileGroupBox.Controls.Add(this.encryptButton);
			this.importFromFileGroupBox.Controls.Add(this.searchSourceFileButton);
			this.importFromFileGroupBox.Controls.Add(this.pathToSourceFileTextBox);
			this.importFromFileGroupBox.Controls.Add(this.label1);
			this.importFromFileGroupBox.Location = new System.Drawing.Point(13, 13);
			this.importFromFileGroupBox.Name = "importFromFileGroupBox";
			this.importFromFileGroupBox.Padding = new System.Windows.Forms.Padding(5);
			this.importFromFileGroupBox.Size = new System.Drawing.Size(334, 100);
			this.importFromFileGroupBox.TabIndex = 0;
			this.importFromFileGroupBox.TabStop = false;
			this.importFromFileGroupBox.Text = "Группа";
			// 
			// encryptButton
			// 
			this.encryptButton.Location = new System.Drawing.Point(12, 65);
			this.encryptButton.Name = "encryptButton";
			this.encryptButton.Size = new System.Drawing.Size(109, 23);
			this.encryptButton.TabIndex = 3;
			this.encryptButton.Text = "Зашифровать";
			this.encryptButton.UseVisualStyleBackColor = true;
			this.encryptButton.Click += new System.EventHandler(this.ClickToEncryptButton);
			// 
			// searchSourceFileButton
			// 
			this.searchSourceFileButton.Image = global::OTP.Window.Properties.Resources.search1;
			this.searchSourceFileButton.Location = new System.Drawing.Point(298, 38);
			this.searchSourceFileButton.Name = "searchSourceFileButton";
			this.searchSourceFileButton.Size = new System.Drawing.Size(28, 23);
			this.searchSourceFileButton.TabIndex = 2;
			this.searchSourceFileButton.UseVisualStyleBackColor = true;
			// 
			// pathToSourceFileTextBox
			// 
			this.pathToSourceFileTextBox.Location = new System.Drawing.Point(11, 39);
			this.pathToSourceFileTextBox.Name = "pathToSourceFileTextBox";
			this.pathToSourceFileTextBox.Size = new System.Drawing.Size(281, 20);
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
			// decryptTab
			// 
			this.decryptTab.Controls.Add(this.groupBox1);
			this.decryptTab.Controls.Add(this.groupBox2);
			this.decryptTab.Location = new System.Drawing.Point(4, 34);
			this.decryptTab.Name = "decryptTab";
			this.decryptTab.Padding = new System.Windows.Forms.Padding(3);
			this.decryptTab.Size = new System.Drawing.Size(360, 468);
			this.decryptTab.TabIndex = 1;
			this.decryptTab.Text = "Дешифрование";
			this.decryptTab.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 45);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(314, 97);
			this.textBox1.TabIndex = 0;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(11, 179);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(317, 97);
			this.textBox2.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Исходный текст";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 163);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(123, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Зашифрованный текст";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 282);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Зашифровать";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.textBox4);
			this.groupBox1.Location = new System.Drawing.Point(13, 133);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(334, 322);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox2";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(12, 282);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "Зашифровать";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 163);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(125, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Дешифрованный текст";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(9, 29);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(89, 13);
			this.label5.TabIndex = 2;
			this.label5.Text = "Исходный текст";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(11, 179);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(317, 97);
			this.textBox3.TabIndex = 1;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(12, 45);
			this.textBox4.Multiline = true;
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(314, 97);
			this.textBox4.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button3);
			this.groupBox2.Controls.Add(this.button4);
			this.groupBox2.Controls.Add(this.textBox5);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Location = new System.Drawing.Point(13, 13);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
			this.groupBox2.Size = new System.Drawing.Size(334, 100);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Группа";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(12, 65);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(109, 23);
			this.button3.TabIndex = 3;
			this.button3.Text = "Дешифровать";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Image = global::OTP.Window.Properties.Resources.search1;
			this.button4.Location = new System.Drawing.Point(298, 38);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(28, 23);
			this.button4.TabIndex = 2;
			this.button4.UseVisualStyleBackColor = true;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(11, 39);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(281, 20);
			this.textBox5.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(9, 23);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(87, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Исходный файл";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(392, 545);
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
			this.realTimeGroupBox.ResumeLayout(false);
			this.realTimeGroupBox.PerformLayout();
			this.importFromFileGroupBox.ResumeLayout(false);
			this.importFromFileGroupBox.PerformLayout();
			this.decryptTab.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
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
		private System.Windows.Forms.Button encryptButton;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label6;
	}
}

