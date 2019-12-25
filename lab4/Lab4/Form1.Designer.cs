namespace files
{
    partial class MainForm
    {
        
        private System.ComponentModel.IContainer components = null;

        
        protected override void Dispose(bool disposing){
            if (disposing && (components != null)){
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ReadButton = new System.Windows.Forms.Button();
            this.ReadTimeLabel = new System.Windows.Forms.Label();
            this.ReadCountLabel = new System.Windows.Forms.Label();
            this.ReadTimeText = new System.Windows.Forms.TextBox();
            this.ReadCountText = new System.Windows.Forms.TextBox();
            this.SearchWordButton = new System.Windows.Forms.Label();
            this.SearchWordText = new System.Windows.Forms.TextBox();
            this.ExactSearchButton = new System.Windows.Forms.Button();
            this.ExactSearchTimeLabel = new System.Windows.Forms.Label();
            this.ExactSearchTimeText = new System.Windows.Forms.TextBox();
            this.ResultBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ReadButton
            // 
            this.ReadButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReadButton.Location = new System.Drawing.Point(12, 12);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(144, 36);
            this.ReadButton.TabIndex = 0;
            this.ReadButton.Text = "Чтение из файла";
            this.ReadButton.UseVisualStyleBackColor = true;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // ReadTimeLabel
            // 
            this.ReadTimeLabel.AutoSize = true;
            this.ReadTimeLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReadTimeLabel.Location = new System.Drawing.Point(186, 20);
            this.ReadTimeLabel.Name = "ReadTimeLabel";
            this.ReadTimeLabel.Size = new System.Drawing.Size(160, 20);
            this.ReadTimeLabel.TabIndex = 1;
            this.ReadTimeLabel.Text = "Время чтения из файла:";
            // 
            // ReadCountLabel
            // 
            this.ReadCountLabel.AutoSize = true;
            this.ReadCountLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReadCountLabel.Location = new System.Drawing.Point(186, 57);
            this.ReadCountLabel.Name = "ReadCountLabel";
            this.ReadCountLabel.Size = new System.Drawing.Size(253, 20);
            this.ReadCountLabel.TabIndex = 2;
            this.ReadCountLabel.Text = "Количество уникальных слов в файле:";
            // 
            // ReadTimeText
            // 
            this.ReadTimeText.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReadTimeText.Location = new System.Drawing.Point(445, 17);
            this.ReadTimeText.Name = "ReadTimeText";
            this.ReadTimeText.ReadOnly = true;
            this.ReadTimeText.Size = new System.Drawing.Size(150, 26);
            this.ReadTimeText.TabIndex = 3;
            // 
            // ReadCountText
            // 
            this.ReadCountText.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReadCountText.Location = new System.Drawing.Point(445, 54);
            this.ReadCountText.Name = "ReadCountText";
            this.ReadCountText.ReadOnly = true;
            this.ReadCountText.Size = new System.Drawing.Size(150, 26);
            this.ReadCountText.TabIndex = 4;
            // 
            // SearchWordButton
            // 
            this.SearchWordButton.AutoSize = true;
            this.SearchWordButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchWordButton.Location = new System.Drawing.Point(30, 127);
            this.SearchWordButton.Name = "SearchWordButton";
            this.SearchWordButton.Size = new System.Drawing.Size(126, 20);
            this.SearchWordButton.TabIndex = 5;
            this.SearchWordButton.Text = "Слово для поиска:";
            // 
            // SearchWordText
            // 
            this.SearchWordText.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchWordText.Location = new System.Drawing.Point(190, 124);
            this.SearchWordText.Name = "SearchWordText";
            this.SearchWordText.Size = new System.Drawing.Size(405, 26);
            this.SearchWordText.TabIndex = 6;
            // 
            // ExactSearchButton
            // 
            this.ExactSearchButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExactSearchButton.Location = new System.Drawing.Point(12, 179);
            this.ExactSearchButton.Name = "ExactSearchButton";
            this.ExactSearchButton.Size = new System.Drawing.Size(144, 36);
            this.ExactSearchButton.TabIndex = 7;
            this.ExactSearchButton.Text = "Поиск";
            this.ExactSearchButton.UseVisualStyleBackColor = true;
            this.ExactSearchButton.Click += new System.EventHandler(this.ExactSearchButton_Click);
            // 
            // ExactSearchTimeLabel
            // 
            this.ExactSearchTimeLabel.AutoSize = true;
            this.ExactSearchTimeLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExactSearchTimeLabel.Location = new System.Drawing.Point(186, 187);
            this.ExactSearchTimeLabel.Name = "ExactSearchTimeLabel";
            this.ExactSearchTimeLabel.Size = new System.Drawing.Size(100, 20);
            this.ExactSearchTimeLabel.TabIndex = 8;
            this.ExactSearchTimeLabel.Text = "Время поиска:";
            // 
            // ExactSearchTimeText
            // 
            this.ExactSearchTimeText.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExactSearchTimeText.Location = new System.Drawing.Point(292, 184);
            this.ExactSearchTimeText.Name = "ExactSearchTimeText";
            this.ExactSearchTimeText.ReadOnly = true;
            this.ExactSearchTimeText.Size = new System.Drawing.Size(115, 26);
            this.ExactSearchTimeText.TabIndex = 9;
            // 
            // ResultBox
            // 
            this.ResultBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultBox.FormattingEnabled = true;
            this.ResultBox.ItemHeight = 20;
            this.ResultBox.Location = new System.Drawing.Point(12, 221);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(583, 300);
            this.ResultBox.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 534);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.ExactSearchTimeText);
            this.Controls.Add(this.ExactSearchTimeLabel);
            this.Controls.Add(this.ExactSearchButton);
            this.Controls.Add(this.SearchWordText);
            this.Controls.Add(this.SearchWordButton);
            this.Controls.Add(this.ReadCountText);
            this.Controls.Add(this.ReadTimeText);
            this.Controls.Add(this.ReadCountLabel);
            this.Controls.Add(this.ReadTimeLabel);
            this.Controls.Add(this.ReadButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Поиск в файле";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReadButton;
        private System.Windows.Forms.Label ReadTimeLabel;
        private System.Windows.Forms.Label ReadCountLabel;
        private System.Windows.Forms.TextBox ReadTimeText;
        private System.Windows.Forms.TextBox ReadCountText;
        private System.Windows.Forms.Label SearchWordButton;
        private System.Windows.Forms.TextBox SearchWordText;
        private System.Windows.Forms.Button ExactSearchButton;
        private System.Windows.Forms.Label ExactSearchTimeLabel;
        private System.Windows.Forms.TextBox ExactSearchTimeText;
        private System.Windows.Forms.ListBox ResultBox;
    }
}

