using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Koshmanov.Game15;
using Koshmanov.TextEditor;

namespace Koshmanov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pbGame1_Click(object sender, EventArgs e)
        {
            Form game15 = new Game15.Form1();
            game15.ShowDialog();
        }

        private void pbSoft1_Click(object sender, EventArgs e)
        {
            Form textEditor = new TextEditor.MainText();
            textEditor.ShowDialog();
        }
    }
}
