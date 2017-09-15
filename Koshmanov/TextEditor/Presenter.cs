using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Koshmanov.TextEditorLibrary;

namespace Koshmanov.TextEditor
{
    public class Presenter
    {
        private readonly IMainText _view;
        private readonly IFileManager _manager;
        private readonly IMessageService _messageService;
        private string _currentFilePath;

        public Presenter(IMainText view, IFileManager manager, IMessageService service)
        {
            _view = view;
            _manager = manager;
            _messageService = service;

            _view.SetSymbolCount(0);
            _view.ContentChanged += _view_ContentChanged;
            _view.FileOpenClick += _view_FileOpenClick;
            _view.FileSaveClick += _view_FileSaveClick;
        }

        private void _view_FileSaveClick(object sender, EventArgs e)
        {
            try
            {
                string content = _view.Content;
                _manager.SaveContent(content, _currentFilePath);
                _messageService.ShowMessage("Файл успешно сохранён.");
            }
            catch (Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }
        }

        private void _view_FileOpenClick(object sender, EventArgs e)
        {
            try
            {
                string filePath = _view.FilePath;
                if (!(_manager.IsExist(filePath)))
                {
                    _messageService.ShowExclamation("Выбраный файл не существует");
                    return;
                }
                _currentFilePath = filePath;
                string content = _manager.GetContent(filePath);
                int count = _manager.GetSymbolCount(content);

                _view.Content = content;
                _view.SetSymbolCount(count);
            }
            catch(Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }
        }

        private void _view_ContentChanged(object sender, EventArgs e)
        {
            string content = _view.Content;

            int count = _manager.GetSymbolCount(content);

            _view.SetSymbolCount(count);
        }
    }
}
