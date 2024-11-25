using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatern
{


    internal class DeleteTextCommand : ICommand
    {
        private readonly TextEditor _editor;
        private readonly int _lengthToDelete;
        private string _deletedText = "";

        public DeleteTextCommand(TextEditor editor, int lengthToDelete)
        {
            _editor = editor;
            _lengthToDelete = lengthToDelete;
        }

        public void Execute()
        {
            if (_lengthToDelete <= _editor.GetText().Length)
            {
                _deletedText = _editor.GetText().Substring(_editor.GetText().Length - _lengthToDelete);
            }
            else
            {
                _deletedText = _editor.GetText();
            }
            _editor.Delete(_lengthToDelete);
        }

        public void Undo()
        {
            _editor.Insert(_deletedText);
        }
    }
}
