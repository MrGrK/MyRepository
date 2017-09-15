using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Koshmanov.TextEditor;
using Koshmanov.TextEditorLibrary;

namespace Koshmanov.TextEditor
{
    public interface IMainText
    {
        string FilePath { get; }
        string Content { get; set; }
        void SetSymbolCount(int count);
        event EventHandler FileOpenClick;
        event EventHandler FileSaveClick;
        event EventHandler ContentChanged;
    }

    public partial class MainText : Form, IMainText
    {

        MainText main;
        
        
        public MainText()
        {
            InitializeComponent();
            FileManager manager = new FileManager();
            MessageService servic = new MessageService();

            Presenter presenter = new Presenter(this, manager, servic);
            btOpenFile.Click += BtOpenFile_Click;
            btSaveFile.Click += BtSaveFile_Click;
            tbText.TextChanged += TbText_TextChanged;
            numericUpDownFont.ValueChanged += NumericUpDownFont_ValueChanged; // обработчик выбора шрифта
        }

        #region проброс событий
        private void TbText_TextChanged(object sender, EventArgs e)
        {
            ContentChanged?.Invoke(this, EventArgs.Empty);
        }

        private void BtSaveFile_Click(object sender, EventArgs e)
        {
            FileSaveClick?.Invoke(this, EventArgs.Empty);
        }

        private void BtOpenFile_Click(object sender, EventArgs e)
        {
           FileOpenClick?.Invoke(this, EventArgs.Empty);
        }
        #endregion

        #region реализация IMain
        public string FilePath
        {
            get {return tbFilePath.Text;}
        }

        public string Content
        {
            get{return tbText.Text;}
            set{tbText.Text = value;}
        }

        public void SetSymbolCount(int count)
        {
            tsslCount.Text = count.ToString();
        }

        public event EventHandler FileOpenClick;
        public event EventHandler FileSaveClick;
        public event EventHandler ContentChanged;

        #endregion

        private void btSelectFile_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                tbFilePath.Text = ofd.FileName;
                if (FileOpenClick != null)
                    FileOpenClick(this, EventArgs.Empty);
            }
        }

        private void NumericUpDownFont_ValueChanged(object sender, EventArgs e)
        {
            tbText.Font = new Font("Calibri", (float)numericUpDownFont.Value);
        }
    }
}
