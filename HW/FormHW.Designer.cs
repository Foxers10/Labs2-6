namespace WFHomeWork
{
	partial class FormHW
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonReadFile = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.listBoxReport = new System.Windows.Forms.ListBox();
			this.textBoxDownloadTime = new System.Windows.Forms.TextBox();
			this.textBoxSaveTime = new System.Windows.Forms.TextBox();
			this.textBoxSearchingWord = new System.Windows.Forms.TextBox();
			this.textBoxMnogopotochSearchTime = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxRealNumberPotoki = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxNechetDistance = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.textBoxNumberOfPotoki = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.buttonMnogopotochnSearch = new System.Windows.Forms.Button();
			this.buttonCLOSE = new System.Windows.Forms.Button();
			this.buttonSAVEreport_html = new System.Windows.Forms.Button();
			this.textBoxChSearchTime = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.buttonChSearch = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonReadFile
			// 
			this.buttonReadFile.Location = new System.Drawing.Point(13, 13);
			this.buttonReadFile.Name = "buttonReadFile";
			this.buttonReadFile.Size = new System.Drawing.Size(189, 78);
			this.buttonReadFile.TabIndex = 29;
			this.buttonReadFile.Text = "Чтение файла";
			this.buttonReadFile.UseVisualStyleBackColor = true;
			this.buttonReadFile.Click += new System.EventHandler(this.buttonReadFile_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(297, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(162, 17);
			this.label1.TabIndex = 30;
			this.label1.Text = "Время загрузки файла:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(297, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(182, 17);
			this.label2.TabIndex = 31;
			this.label2.Text = "Время сохранения файла:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(130, 17);
			this.label3.TabIndex = 32;
			this.label3.Text = "Слово для поиска:";
			// 
			// listBoxReport
			// 
			this.listBoxReport.FormattingEnabled = true;
			this.listBoxReport.ItemHeight = 16;
			this.listBoxReport.Location = new System.Drawing.Point(320, 206);
			this.listBoxReport.Name = "listBoxReport";
			this.listBoxReport.Size = new System.Drawing.Size(606, 308);
			this.listBoxReport.TabIndex = 33;
			// 
			// textBoxDownloadTime
			// 
			this.textBoxDownloadTime.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.textBoxDownloadTime.Location = new System.Drawing.Point(519, 10);
			this.textBoxDownloadTime.Name = "textBoxDownloadTime";
			this.textBoxDownloadTime.Size = new System.Drawing.Size(274, 22);
			this.textBoxDownloadTime.TabIndex = 34;
			// 
			// textBoxSaveTime
			// 
			this.textBoxSaveTime.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.textBoxSaveTime.Location = new System.Drawing.Point(519, 51);
			this.textBoxSaveTime.Name = "textBoxSaveTime";
			this.textBoxSaveTime.Size = new System.Drawing.Size(274, 22);
			this.textBoxSaveTime.TabIndex = 35;
			// 
			// textBoxSearchingWord
			// 
			this.textBoxSearchingWord.Location = new System.Drawing.Point(15, 145);
			this.textBoxSearchingWord.Name = "textBoxSearchingWord";
			this.textBoxSearchingWord.Size = new System.Drawing.Size(219, 22);
			this.textBoxSearchingWord.TabIndex = 36;
			// 
			// textBoxMnogopotochSearchTime
			// 
			this.textBoxMnogopotochSearchTime.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.textBoxMnogopotochSearchTime.Location = new System.Drawing.Point(14, 473);
			this.textBoxMnogopotochSearchTime.Name = "textBoxMnogopotochSearchTime";
			this.textBoxMnogopotochSearchTime.Size = new System.Drawing.Size(219, 22);
			this.textBoxMnogopotochSearchTime.TabIndex = 38;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(11, 453);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(285, 17);
			this.label5.TabIndex = 37;
			this.label5.Text = "Время многопоточного нечеткого поиска:";
			// 
			// textBoxRealNumberPotoki
			// 
			this.textBoxRealNumberPotoki.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.textBoxRealNumberPotoki.Location = new System.Drawing.Point(15, 419);
			this.textBoxRealNumberPotoki.Name = "textBoxRealNumberPotoki";
			this.textBoxRealNumberPotoki.Size = new System.Drawing.Size(219, 22);
			this.textBoxRealNumberPotoki.TabIndex = 40;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 399);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(239, 17);
			this.label6.TabIndex = 39;
			this.label6.Text = "Вычисленное количество потоков:";
			// 
			// textBoxNechetDistance
			// 
			this.textBoxNechetDistance.Location = new System.Drawing.Point(15, 211);
			this.textBoxNechetDistance.Name = "textBoxNechetDistance";
			this.textBoxNechetDistance.Size = new System.Drawing.Size(219, 22);
			this.textBoxNechetDistance.TabIndex = 42;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(12, 174);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(190, 34);
			this.label9.TabIndex = 41;
			this.label9.Text = "Максимальное расстояние \r\nдля нечеткого поиска:";
			// 
			// textBoxNumberOfPotoki
			// 
			this.textBoxNumberOfPotoki.Location = new System.Drawing.Point(15, 266);
			this.textBoxNumberOfPotoki.Name = "textBoxNumberOfPotoki";
			this.textBoxNumberOfPotoki.Size = new System.Drawing.Size(219, 22);
			this.textBoxNumberOfPotoki.TabIndex = 44;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(12, 246);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(147, 17);
			this.label10.TabIndex = 43;
			this.label10.Text = "Количество потоков:";
			// 
			// buttonMnogopotochnSearch
			// 
			this.buttonMnogopotochnSearch.Location = new System.Drawing.Point(15, 303);
			this.buttonMnogopotochnSearch.Name = "buttonMnogopotochnSearch";
			this.buttonMnogopotochnSearch.Size = new System.Drawing.Size(187, 77);
			this.buttonMnogopotochnSearch.TabIndex = 45;
			this.buttonMnogopotochnSearch.Text = "Многопоточный\r\nнечеткий \r\nпоиск слова";
			this.buttonMnogopotochnSearch.UseVisualStyleBackColor = true;
			this.buttonMnogopotochnSearch.Click += new System.EventHandler(this.buttonMnogopotochnSearch_Click);
			// 
			// buttonCLOSE
			// 
			this.buttonCLOSE.BackColor = System.Drawing.SystemColors.ControlLight;
			this.buttonCLOSE.Location = new System.Drawing.Point(795, 524);
			this.buttonCLOSE.Name = "buttonCLOSE";
			this.buttonCLOSE.Size = new System.Drawing.Size(131, 41);
			this.buttonCLOSE.TabIndex = 46;
			this.buttonCLOSE.Text = "Закрыть форму";
			this.buttonCLOSE.UseVisualStyleBackColor = false;
			this.buttonCLOSE.Click += new System.EventHandler(this.buttonCLOSE_Click);
			// 
			// buttonSAVEreport_html
			// 
			this.buttonSAVEreport_html.Location = new System.Drawing.Point(12, 501);
			this.buttonSAVEreport_html.Name = "buttonSAVEreport_html";
			this.buttonSAVEreport_html.Size = new System.Drawing.Size(221, 64);
			this.buttonSAVEreport_html.TabIndex = 47;
			this.buttonSAVEreport_html.Text = "Сохранить отчет в формате .html";
			this.buttonSAVEreport_html.UseVisualStyleBackColor = true;
			this.buttonSAVEreport_html.Click += new System.EventHandler(this.buttonSAVEreport_Click);
			// 
			// textBoxChSearchTime
			// 
			this.textBoxChSearchTime.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.textBoxChSearchTime.Location = new System.Drawing.Point(707, 145);
			this.textBoxChSearchTime.Name = "textBoxChSearchTime";
			this.textBoxChSearchTime.Size = new System.Drawing.Size(219, 22);
			this.textBoxChSearchTime.TabIndex = 49;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(704, 108);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(105, 34);
			this.label4.TabIndex = 48;
			this.label4.Text = "Время четкого\r\nпоиска слова:";
			// 
			// buttonChSearch
			// 
			this.buttonChSearch.Location = new System.Drawing.Point(416, 112);
			this.buttonChSearch.Name = "buttonChSearch";
			this.buttonChSearch.Size = new System.Drawing.Size(176, 58);
			this.buttonChSearch.TabIndex = 50;
			this.buttonChSearch.Text = "Четкий поиск слова";
			this.buttonChSearch.UseVisualStyleBackColor = true;
			this.buttonChSearch.Click += new System.EventHandler(this.buttonChSearch_Click);
			// 
			// FormHW
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(938, 577);
			this.Controls.Add(this.buttonChSearch);
			this.Controls.Add(this.textBoxChSearchTime);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.buttonSAVEreport_html);
			this.Controls.Add(this.buttonCLOSE);
			this.Controls.Add(this.buttonMnogopotochnSearch);
			this.Controls.Add(this.textBoxNumberOfPotoki);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.textBoxNechetDistance);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.textBoxRealNumberPotoki);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBoxMnogopotochSearchTime);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBoxSearchingWord);
			this.Controls.Add(this.textBoxSaveTime);
			this.Controls.Add(this.textBoxDownloadTime);
			this.Controls.Add(this.listBoxReport);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonReadFile);
			this.Name = "FormHW";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonReadFile;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListBox listBoxReport;
		private System.Windows.Forms.TextBox textBoxDownloadTime;
		private System.Windows.Forms.TextBox textBoxSaveTime;
		private System.Windows.Forms.TextBox textBoxSearchingWord;
		private System.Windows.Forms.TextBox textBoxMnogopotochSearchTime;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxRealNumberPotoki;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxNechetDistance;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBoxNumberOfPotoki;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button buttonMnogopotochnSearch;
		private System.Windows.Forms.Button buttonCLOSE;
		private System.Windows.Forms.Button buttonSAVEreport_html;
		private System.Windows.Forms.TextBox textBoxChSearchTime;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button buttonChSearch;
	}
}

