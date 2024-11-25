using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatern
{
    internal class TextEditor
    {
        private string _text = "";

        public void Insert(string text)
        {
            _text += text;
            Console.WriteLine($"Текущий текст: \"{_text}\"");
        }

        public void Delete(int length)
        {
            if (length > _text.Length)
            {
                length = _text.Length;
            }
            _text = _text.Substring(0, _text.Length - length);
            Console.WriteLine($"Текущий текст: \"{_text}\"");
        }

        public string GetText() => _text;
    }
}
