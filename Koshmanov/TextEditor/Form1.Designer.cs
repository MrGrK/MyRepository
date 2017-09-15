namespace Koshmanov.TextEditor
{
    partial class MainText
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
            this.lbFilePath = new System.Windows.Forms.Label();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.btSelectFile = new System.Windows.Forms.Button();
            this.btOpenFile = new System.Windows.Forms.Button();
            this.lbFont = new System.Windows.Forms.Label();
            this.numericUpDownFont = new System.Windows.Forms.NumericUpDown();
            this.tbText = new System.Windows.Forms.TextBox();
            this.btSaveFile = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbCound = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCount = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFont)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFilePath
            // 
            this.lbFilePath.AutoSize = true;
            this.lbFilePath.Location = new System.Drawing.Point(20, 39);
            this.lbFilePath.Name = "lbFilePath";
            this.lbFilePath.Size = new System.Drawing.Size(86, 13);
            this.lbFilePath.TabIndex = 0;
            this.lbFilePath.Text = "Выберите файл";
            // 
            // tbFilePath
            // 
            this.tbFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilePath.Location = new System.Drawing.Point(112, 35);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(381, 20);
            this.tbFilePath.TabIndex = 1;
            // 
            // btSelectFile
            // 
            this.btSelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSelectFile.Location = new System.Drawing.Point(509, 33);
            this.btSelectFile.Name = "btSelectFile";
            this.btSelectFile.Size = new System.Drawing.Size(75, 23);
            this.btSelectFile.TabIndex = 2;
            this.btSelectFile.Text = "Выбрать";
            this.btSelectFile.UseVisualStyleBackColor = true;
            this.btSelectFile.Click += new System.EventHandler(this.btSelectFile_Click_1);
            // 
            // btOpenFile
            // 
            this.btOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btOpenFile.Location = new System.Drawing.Point(601, 33);
            this.btOpenFile.Name = "btOpenFile";
            this.btOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btOpenFile.TabIndex = 3;
            this.btOpenFile.Text = "Открыть";
            this.btOpenFile.UseVisualStyleBackColor = true;
            // 
            // lbFont
            // 
            this.lbFont.AutoSize = true;
            this.lbFont.Location = new System.Drawing.Point(20, 81);
            this.lbFont.Name = "lbFont";
            this.lbFont.Size = new System.Drawing.Size(41, 13);
            this.lbFont.TabIndex = 4;
            this.lbFont.Text = "Шрифт";
            // 
            // numericUpDownFont
            // 
            this.numericUpDownFont.Location = new System.Drawing.Point(112, 79);
            this.numericUpDownFont.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.numericUpDownFont.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDownFont.Name = "numericUpDownFont";
            this.numericUpDownFont.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownFont.TabIndex = 5;
            this.numericUpDownFont.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // tbText
            // 
            this.tbText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbText.Location = new System.Drawing.Point(23, 131);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbText.Size = new System.Drawing.Size(653, 226);
            this.tbText.TabIndex = 6;
            // 
            // btSaveFile
            // 
            this.btSaveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSaveFile.Location = new System.Drawing.Point(601, 363);
            this.btSaveFile.Name = "btSaveFile";
            this.btSaveFile.Size = new System.Drawing.Size(75, 23);
            this.btSaveFile.TabIndex = 7;
            this.btSaveFile.Text = "Сохранить";
            this.btSaveFile.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.lbCound,
            this.tsslCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 389);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(698, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(130, 17);
            this.toolStripStatusLabel1.Text = "Количество символов";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // lbCound
            // 
            this.lbCound.Name = "lbCound";
            this.lbCound.Size = new System.Drawing.Size(0, 17);
            // 
            // tsslCount
            // 
            this.tsslCount.Name = "tsslCount";
            this.tsslCount.Size = new System.Drawing.Size(19, 17);
            this.tsslCount.Text = "11";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 411);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btSaveFile);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.numericUpDownFont);
            this.Controls.Add(this.lbFont);
            this.Controls.Add(this.btOpenFile);
            this.Controls.Add(this.btSelectFile);
            this.Controls.Add(this.tbFilePath);
            this.Controls.Add(this.lbFilePath);
            this.Name = "Main";
            this.Text = "TextEditor";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFont)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFilePath;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Button btSelectFile;
        private System.Windows.Forms.Button btOpenFile;
        private System.Windows.Forms.Label lbFont;
        private System.Windows.Forms.NumericUpDown numericUpDownFont;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Button btSaveFile;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lbCound;
        private System.Windows.Forms.ToolStripStatusLabel tsslCount;
    }
}

