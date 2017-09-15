using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Koshmanov.Game15;
using Koshmanov.TextEditor;
using Koshmanov.TextEditorLibrary;
namespace Koshmanov
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //MainText main = new MainText();
            //FileManager manager = new FileManager();
            //MessageService servic = new MessageService();

            //Presenter presenter = new Presenter(main, manager, servic);

            Application.Run(new Form1());
        }
    }
}
