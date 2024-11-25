using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatern
{
    internal class InsertTextCommand : ICommand
    {
        private readonly TextEditor _editor;
        private readonly string _textToInsert;

        public InsertTextCommand(TextEditor editor, string textToInsert)
        {
            _editor = editor;
            _textToInsert = textToInsert;
        }

        public void Execute()
        {
            _editor.Insert(_textToInsert);
        }

        public void Undo()
        {
            _editor.Delete(_textToInsert.Length);
        }
    }
}
