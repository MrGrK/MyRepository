namespace Koshmanov
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabpGame = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.pbGame1 = new System.Windows.Forms.PictureBox();
            this.tabpSoft = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.pbSoft1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabpGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGame1)).BeginInit();
            this.tabpSoft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSoft1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabpGame);
            this.tabControl1.Controls.Add(this.tabpSoft);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(475, 405);
            this.tabControl1.TabIndex = 0;
            // 
            // tabpGame
            // 
            this.tabpGame.Controls.Add(this.label1);
            this.tabpGame.Controls.Add(this.pbGame1);
            this.tabpGame.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabpGame.Location = new System.Drawing.Point(4, 22);
            this.tabpGame.Name = "tabpGame";
            this.tabpGame.Padding = new System.Windows.Forms.Padding(3);
            this.tabpGame.Size = new System.Drawing.Size(467, 379);
            this.tabpGame.TabIndex = 0;
            this.tabpGame.Text = "Game";
            this.tabpGame.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(46, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Игра пятнашки";
            // 
            // pbGame1
            // 
            this.pbGame1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbGame1.Image = global::Koshmanov.Properties.Resources.скрин1;
            this.pbGame1.Location = new System.Drawing.Point(7, 6);
            this.pbGame1.Name = "pbGame1";
            this.pbGame1.Size = new System.Drawing.Size(177, 125);
            this.pbGame1.TabIndex = 0;
            this.pbGame1.TabStop = false;
            this.pbGame1.Click += new System.EventHandler(this.pbGame1_Click);
            // 
            // tabpSoft
            // 
            this.tabpSoft.Controls.Add(this.label2);
            this.tabpSoft.Controls.Add(this.pbSoft1);
            this.tabpSoft.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabpSoft.Location = new System.Drawing.Point(4, 22);
            this.tabpSoft.Name = "tabpSoft";
            this.tabpSoft.Padding = new System.Windows.Forms.Padding(3);
            this.tabpSoft.Size = new System.Drawing.Size(467, 379);
            this.tabpSoft.TabIndex = 1;
            this.tabpSoft.Text = "Soft";
            this.tabpSoft.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Текстовый редактор на основе паттерна MVP";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbSoft1
            // 
            this.pbSoft1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSoft1.Image = global::Koshmanov.Properties.Resources.скрин2;
            this.pbSoft1.Location = new System.Drawing.Point(7, 6);
            this.pbSoft1.Name = "pbSoft1";
            this.pbSoft1.Size = new System.Drawing.Size(177, 125);
            this.pbSoft1.TabIndex = 1;
            this.pbSoft1.TabStop = false;
            this.pbSoft1.Click += new System.EventHandler(this.pbSoft1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 405);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Библиотека программ";
            this.tabControl1.ResumeLayout(false);
            this.tabpGame.ResumeLayout(false);
            this.tabpGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGame1)).EndInit();
            this.tabpSoft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSoft1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabpGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbGame1;
        private System.Windows.Forms.TabPage tabpSoft;
        private System.Windows.Forms.PictureBox pbSoft1;
        private System.Windows.Forms.Label label2;
    }
}

